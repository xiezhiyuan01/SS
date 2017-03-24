using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;
using SS.Models;
namespace SS.Controllers

{
    public class ProductController : Controller
    {
       private  IProductRepository repository;
        public ProductController(IProductRepository iPR)
        {
            repository = iPR;
        }
        int pageSize = 4;
        // GET: Product
        public ViewResult List(string category,int page=1)
        {
            ProductListView model = new ProductListView
            {
                Products = repository.Products.OrderBy(p => p.ProductID).Skip((page - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo{ CurrentPage = page, TotalItems = repository.Products.Count(), ItemsPerPage = pageSize },
                CurrentCategory=category
            };

            return View(model);
        }
    }
}