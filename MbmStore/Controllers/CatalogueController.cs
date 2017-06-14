using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {

        // object
        // private Repository repository = new Repository();

        // GET: Catalogue
        public ActionResult Index()
        {
            Repository repository = new Repository();

            List<SelectListItem> Quantity = new List<SelectListItem>();

            for (int i = 0; i <= 100; i++)
            {
                Quantity.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            ViewBag.Quantity = Quantity;
            
            return View(repository.Products);
        }
    }
}