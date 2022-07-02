using Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator
{
    public class ConcreteCreatorB : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductB { Name = "Product B", Price = 20 };
        }
    }
}
