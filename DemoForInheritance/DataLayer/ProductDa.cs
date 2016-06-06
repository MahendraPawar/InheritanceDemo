using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Model;

namespace DataLayer
{
    public class ProductDa : BaseDa<Product>
    {
        public sealed override int Insert(Product obj)
        {
            Console.WriteLine("From derived insert");
            return 0;
        }
    }
}
