using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14SepTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Orange();
            Pineapple pineapple = new Pineapple();
            Fruit[] basket = new Fruit[3] { apple, orange, pineapple };

            foreach (Fruit f in basket)
            {
          

                Apple apple1 = f as Apple;
                Orange orange1  = f as Orange;
                Pineapple pineapple1 = f as Pineapple;

                if (apple1 != null)
                {
                    Console.WriteLine(apple1.Taste());
                }
                else if(orange1 != null)
                {
                    Console.WriteLine(orange1.Taste());
                }else if(pineapple1 != null)
                {
                    Console.WriteLine(pineapple1.Taste());
                }
          

            }



        }
    }
}
