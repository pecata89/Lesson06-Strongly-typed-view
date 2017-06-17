using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
using MbmStore.ViewModels;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public int PageSize = 2;

        // object
        // private Repository repository = new Repository();

        // GET: Catalogue
        public ActionResult Index(string category, int page = 1)
        {
            Repository repository = new Repository();

            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => category == null || p.Category == category).Count()
                },
                CurrentCategory = category
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