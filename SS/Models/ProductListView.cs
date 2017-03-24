using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS.Models
{
    public class ProductListView
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}