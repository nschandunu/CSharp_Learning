using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {
            }
            else if ( number2 == 16 )
            {
            }
            else if (number3 == 16)
            {
            }*/

            /*int[] numbers = new int[6];
            
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;
            
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);  // How many items in the array
            Console.ReadLine();*/

            
            
            // int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Mitcheal", "David" };
            /*for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }*/

            
            /*foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/

            string zig = "lorem lorem lorem lorem lorem";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }


        }
    }
}