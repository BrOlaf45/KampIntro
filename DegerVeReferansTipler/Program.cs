using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, double, bool (0-1) ----> değer tip
            int sayi1 = 10;
            int sayi2 = 30;
            Console.WriteLine("Sayı1 : " + sayi1 + "\nSayı2 : " + sayi2);
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||");
            sayi1 = sayi2; 
            sayi2 = 65;
            Console.WriteLine("Sayı1 : " + sayi1 + "\nSayı2 : " + sayi2);

            Console.WriteLine("---------------------------------------");

            // array, class, interface ---> referans tip
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            Console.WriteLine("DiziSayı1 : " + sayilar1[0] + "\nDiziSayı2 : " + sayilar2[0]);
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||");
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine("DiziSayı1 : " + sayilar1[0] + "\nDiziSayı2 : " + sayilar2[0]);
            // sayilar1[0] = ?


            /*      stack                       heap
             *   -----------               --------------
             * sayi1 = 10 -> 30                 xxx 
             * sayi2 = 30 -> 65                 xxx
             * 
             * 101/ sayilar1   ----new----> 101 nolu adreste tutulur [10,20,30] 
             * 102/ sayilar2   ----new----> 102 nolu adreste tutulur [100,200,300]
             * 
             * sayilar1 = sayilar2 dendiğinde sayilar1'e ait olan 101 adres 102 olur,
             * 101 nolu adreste tutulan veriler yok olur, atılır (garbage collector) ve
             * sayilar1 artık 102 nolu adrese bağlanır.
             * 
             */


        }
    }
}
