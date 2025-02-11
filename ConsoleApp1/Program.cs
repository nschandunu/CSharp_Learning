using System;

class Program
{
    static void Main(string[] args)
    {
        PrintMessage("Hello, World!", 5);
    }

    static void PrintMessage(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }
}
    
    
    
