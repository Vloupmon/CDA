using System.Linq;
using jeudontonestleheros.Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.Web.UI.Controllers {

    public class AdventureController : Controller {

        public ActionResult Index([FromServices] DefaultContext context) {
            this.ViewBag.MonTitre = "Aventures";

            var query = from item in context.Adventures
                        select item;

            return View(query.ToList());
        }
    }
}