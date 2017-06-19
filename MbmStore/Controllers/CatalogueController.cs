using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MbmStore.Models;
using MbmStore.ViewModels;
using MbmStore.Infrastructure;
using MbmStore.DAL;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        private MbmStoreContext db;

        public int PageSize = 2;

        // object
        // private Repository repository = new Repository();

        // GET: Catalogue
        public ActionResult Index(string category, int page = 1)
        {
            // Repository repository = new Repository();

            // object that we use to connect to the db
            db = new MbmStoreContext();

            ProductsListViewModel model = new ProductsListViewModel()
            {
                Products = db.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    .ToList(),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    db.Products.Count() :
                    db.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category,

                MusicCDs = db.MusicCDs.Include(m => m.Tracks).ToList()
            };

            List<SelectListItem> Quantity = new List<SelectListItem>();

            for (int i = 1; i <= 100; i++)
            {
                Quantity.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }

            ViewBag.Quantity = Quantity;

            return View(model);
        }
    }
}