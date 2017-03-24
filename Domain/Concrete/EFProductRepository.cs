using System.Collections.Generic;
using Domain.Abstract;

using Domain.Entities;
using Domain.Concrete;

namespace Domain.Concrete
{
  public  class EFProductRepository:IProductRepository
    {
      private   EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
