using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product01 = new Product();
            product01.Name = "Elma";
            product01.Price = 15;
            product01.Explanation = "Amasya elması";

            Product product02 = new Product();
            product02.Name = "Karpuz";
            product02.Price = 80;
            product02.Explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product01,product02};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("------------------\n");
            }

            Console.WriteLine("/*/*/*/*/*/ METHODS /*/*/*/*/*/\n");

            // instance - örnek
            // encapsulation - kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product01);
            sepetManager.Add(product02);

            /* sepetManager Add2'ye parametre eklendiğinde burası patlar,
             * bu yüzden ürünleri class içinde tanımlamak daha doğrudur!!!
             */
            sepetManager.Add2("Armut","Yeşil armut",12, 10);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diy.Karpuzu", 12, 8);
        }
    }
}
