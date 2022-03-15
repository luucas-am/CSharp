using System;

namespace photografy
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a value for width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter a value for height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (width > height)
                Console.WriteLine("It's a landscape.");
            else if (width < height)
                Console.WriteLine("It's a portrait.");
            else
                Console.WriteLine("It's a square photo.");

        }
    }
}