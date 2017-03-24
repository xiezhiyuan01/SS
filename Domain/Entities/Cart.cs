using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public  class Cart
    {
        
        private  List<CartLine> linecollection = new List<CartLine>();
        public IEnumerable<CartLine> Lines
        {
            get { return linecollection; }
        }

        public void  AddItem(Product product, int quantity)
        {
            CartLine line = linecollection.Where(p => p.Product.ProductID == product.ProductID).FirstOrDefault();
            if (line == null)
            {
                linecollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
            
        }
        public void RemoveLine(Product product)
        {
            linecollection.RemoveAll(p => p.Product.ProductID == product.ProductID);
        }
        public void clear()
        {
            linecollection.Clear();
        }
        public decimal TotalPrice()
        {
          return   linecollection.Sum(e => e.Product.Price * e.Quantity);
        }





    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
