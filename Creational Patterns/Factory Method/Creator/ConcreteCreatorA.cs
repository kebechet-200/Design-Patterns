using Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator
{
    public class ConcreteCreatorA : ICreator
    {
        public IProduct CreateProduct()
        {
            return new ProductA { Name = "Product A", Price = 30 };
        }
    }
}
