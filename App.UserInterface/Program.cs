using DatabaseFirstApproach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AdventureWorks())
            {
                var product = new ProductModel()
                {
                    CatalogDescription = "des",
                    ModifiedDate = DateTime.Today,
                    Name = "name",
                    rowguid = Guid.NewGuid(),
                    ProductModelID = 18513
                };

                context.ProductModels.Add(product);
                context.SaveChanges();
            }
        }
    }
}
