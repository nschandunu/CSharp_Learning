using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Jetbrains's big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message;

            if (userValue == "1")
                message = "You won $10000!";
            else if (userValue == "2")
                message = "You won a Brand new Car!";
            else if (userValue == "3")
                message = "You won nothing, sorry!";
            else
            {
                message = "Sorry. We didn't understand. ";
                // message = message + "YouLose.";
                message += "You Lose.";
            }
            Console.WriteLine(message);
            Console.ReadLine();*/
            
            Console.WriteLine("Jetbrains's big giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "$10000" : "strand of lint";
            
            /*Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");*/
            
            Console.WriteLine("You won a "+ message + ".");
            Console.WriteLine("You won a {0}. ",message);
            Console.WriteLine("You entered: {0}, therefore you won a {1}.",userValue, message);
            
            Console.ReadLine();
        }
}
}