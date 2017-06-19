using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;
using MbmStore.DAL;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        // private Repository repository;

        private MbmStoreContext db;
        
        // constructor
        // instantiate a new repository object
        public CartController()
        {
            db = new MbmStoreContext();
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndex
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl, int quantity)
        {
            Product product = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.AddItem(product, quantity);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                cart.RemoveItem(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
    }
}