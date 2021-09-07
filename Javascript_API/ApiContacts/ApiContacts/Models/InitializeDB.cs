using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiContacts.Models
{
    public static class SeedData
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContactsDB(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ContactsDB>>()))
            {

                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.AddRange(
                    new User
                    {
                        Name = "Bost",
                        UserName = "Vincent Bost",
                        Phone = "06 40 75 27 78",
                        Email = "vincent.bost@afpa.fr",
                        BirthDay = new DateTime(1962, 01, 13),
                        PhotoUrl = "UsersPhotos/1.png",
                        Address = new Address()
                        {
                            City = "Sainte Féréole",
                            Street = "2 route de la Maurie Haut",
                            Suite = "La Maurie",
                            ZipCode = "19270",
                            Geo = new Geo() { Longitude = "1.5828", Latitude = "45.2281" }
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}