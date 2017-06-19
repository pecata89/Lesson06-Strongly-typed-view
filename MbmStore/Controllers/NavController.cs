using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.ViewModels;
using MbmStore.DAL;

namespace MbmStore.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        //Repository repository = new Repository();

        private MbmStoreContext db;

        public NavController()
        {
            db = new MbmStoreContext();
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = db.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);
        }

        public PartialViewResult NavBar(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = db.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}