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

            return View(repository.Products);
        }
    }
}