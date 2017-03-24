using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Concrete;
using Domain.Abstract;

namespace SS.Controllers
{
    public class NavController : Controller
    {
        protected IProductRepository repo;
        public NavController(IProductRepository iPR) { repo = iPR; }
        // GET: Nav
        public PartialViewResult Menu(string category=null)
        {
            ViewBag.selectCategory = category;
            IEnumerable<string> categorys = repo.Products.Select(x => x.Category).Distinct().OrderBy(o => o);
            return PartialView(categorys);
        }
    }
}