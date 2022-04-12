using Homework.Erzaqlar;
using System;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Mehsullar mehsullar = new Mehsullar("Cay");

            mehsullar.Count = 10;
            mehsullar.Price = 3;

            sud sud = new sud("Azersud");

            sud.Count = 5;
            sud.Price = 2;

            Console.WriteLine(sud.Count);
            Console.WriteLine(sud.TotalIncome);
            Console.WriteLine("Mehsul bitmisdir");

                  

            Console.WriteLine(mehsullar.Count);
            Console.WriteLine(mehsullar.TotalIncome);
            Console.WriteLine("Mehsul bitmisdir");
            


        }
    }
}
    

