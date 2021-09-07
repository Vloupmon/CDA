using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ApiContacts.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiContacts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AutorisationsLarges")]
    public class UploadController : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        private readonly ContactsDB _context;

        public UploadController(IWebHostEnvironment environment, ContactsDB context)
        {
            _environment = environment;
            _context = context;
        }


        [HttpPost("{id}")]
        public async Task<IActionResult> OnPostUploadAsync(int id, List<IFormFile> files)
        {
            HashSet<string> extensionsValides = new HashSet<string>() { ".jpeg", ".jpg", ".png", ".gif" };
            if (files.Any(f => f.Length > 1000000))
            {
                return BadRequest(new { error = "la taille d'un fichier transmis ne peut excéder 1 Mo." });
            }
            // Uniquement les extensions présentes dans la liste
            if(files.
                Where(f => !extensionsValides.Any(ev => f.FileName[f.FileName.LastIndexOf('.')..] == ev))
                .ToList().Count>0)
            {
                return BadRequest(new { error = "Ce type de fichier n'est pas autorisé." });
            }

            User user = _context.Users.Find(id);
            if (user == null)
            {
                return BadRequest(new { error = "Aucun utilisateur connu sous cet identifiant" });
            }
            try
            {
                int i = 0;
                bool traite = false;
                while (i < files.Count && !traite)
                {
                    if (files[i].Length > 0)
                    {
                        string extension = files[i].FileName[files[i].FileName.LastIndexOf('.')..];
                        if (!string.IsNullOrEmpty(user.PhotoUrl))
                        {
                            string pathOld = Path.Combine(new string[] { _environment.ContentRootPath, "UsersPhotos", user.PhotoUrl });
                            if (System.IO.File.Exists(pathOld)){ System.IO.File.Delete(pathOld); }
                        }

                        user.PhotoUrl = Path.GetRandomFileName();
                        user.PhotoUrl = user.PhotoUrl.Replace(user.PhotoUrl[user.PhotoUrl.LastIndexOf('.')..], extension);
                        
                       
                        string filePath = Path.Combine(new string[] { _environment.ContentRootPath,"UsersPhotos",
                           user.PhotoUrl});

                        using (var stream = System.IO.File.Create(filePath))
                        {
                            await files[i].CopyToAsync(stream);
                        }
                        traite = true;
                    }
                }
                if (traite)
                {
                    _context.Entry(user).State = EntityState.Modified;

                    try
                    {
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (_context.Users.Find(id)==null)
                        {
                            return NotFound(new {user = $"Utilisateur {id} non trouvé" });
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return new OkObjectResult(new {file = "Le fichier pour photo a été traité" });
                   
                }

            }
            catch (Exception ex)
            {

                return BadRequest(new { error = "une erreur est survenue dans le traitement" + "\r\n" + ex.Message });
            }
            return BadRequest(new { error = "Aucune photo n'a été enregistrée" });
        }
    }
}