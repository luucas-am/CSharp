using System;

namespace ifstatements
{
    class Program
    {
        static void Main()
        {
            Console.Write("Hello, please enter a number between 1 and 10: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

            var name = "Mosh";

            Console.WriteLine(name);
        }
    }
}
