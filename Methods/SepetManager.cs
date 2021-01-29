using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string explanation, double price, int stock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productName);
        }
    }
}
