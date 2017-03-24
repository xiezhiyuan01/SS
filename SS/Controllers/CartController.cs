using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Concrete;
using SS.Models;

namespace SS.Controllers
{
    public class CartController : Controller
    {
        EFProductRepository repo = new EFProductRepository();
        // GET: Cart
        public ActionResult Index(string returnUrl)
        {
            return View(new CartModelView { Cart = GetCart(), ReturnUrl = returnUrl });
        }
        public RedirectToRouteResult AddToCart(int productID,string returnUrl)
        {
            Product selectProduct = repo.Products.Where(p => p.ProductID == productID).FirstOrDefault();
            if (selectProduct != null) {
                GetCart().AddItem(selectProduct, 1);
             }
          return  RedirectToAction("Index", new { returnUrl });

        }
        public Cart GetCart()
        {
            Cart cart =(Cart) HttpContext.Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                HttpContext.Session["cart"] = cart;
            }
            return cart;
        }
    }
}