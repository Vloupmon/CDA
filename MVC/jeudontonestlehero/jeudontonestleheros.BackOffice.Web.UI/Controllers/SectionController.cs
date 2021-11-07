using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers {

    public class SectionController : Controller {

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Section item) {
            return View();
        }

        public ActionResult Edit(int id) {

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Section item) {
            return View();
        }
    }
}