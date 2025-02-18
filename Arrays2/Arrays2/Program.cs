using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
        class Program
        {
            static void Main(string[] args)
            {
                // method 1
                string[] car = {"BMW", "Benz", "Audi", "Porsche"};
                int[] ages = {20, 30, 40, 50};
                string[] names = new String[3]{"John", "Doe", "Smith"};  // specially mention element count
                int[] age = new int[2] { 21, 22 };

                // change array value
                car[0] = "Toyota";
                
                Console.WriteLine(car[0]);
                Console.WriteLine(car[2]);
                Console.WriteLine(car.Length);
                Console.WriteLine(age[1]);
                
                Array.Reverse(car);
                Console.WriteLine(car[0]);

            }
        }
}