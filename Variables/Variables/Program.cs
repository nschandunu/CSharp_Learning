using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);*/
            
            Console.WriteLine("What's your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type your Last Name: ");
            myLastName = Console.ReadLine();
            
            /*Console.WriteLine("What's your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            
            Console.WriteLine("Type your Last Name: ");
            string myLastName = Console.ReadLine();*/
            
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName +", Whats up!");
        }
    }
}

