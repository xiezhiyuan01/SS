using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS.Models
{
    public class CartModelView
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}