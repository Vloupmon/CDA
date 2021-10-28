using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers {

    public class AventureController : Controller {

        public IActionResult Index() {
            ViewBag.collection = new int[] { 1, 2, 3, 4, 5 };

            return View();
        }
    }
}