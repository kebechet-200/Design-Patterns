using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class ProductB : IProduct
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }

        public void DoStuff()
        {
            Console.WriteLine("Creating Product B");
        }
    }
}
