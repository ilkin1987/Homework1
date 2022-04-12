using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Erzaqlar
{
    class Mehsullar
    {
        public string Adi { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalIncome { get; set; }

        public Mehsullar(string adi)
        {
            Adi = adi;
        }

        public void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
            }
            else
            {
                Console.WriteLine("Mehsul Bitmisdir");
            }
        }
    }
}

