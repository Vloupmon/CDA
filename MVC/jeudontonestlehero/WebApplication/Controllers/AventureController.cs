using System.Collections.Generic;
using jeudontonestleheros.Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers {

    public class AventureController : Controller {

        public IActionResult Index() {
            ViewBag.Title = "Aventures";
            List<Aventure> list = new();

            list.Add(new Aventure() {
                Id = 1,
                Title = "Toto"
            });

            list.Add(new Aventure() {
                Id = 2,
                Title = "Titi"
            });
            return View(list);
        }
    }
}