using System;

namespace numbers
{
    class Program
    {
        static void Main()
        {
            var sum = 0;
            do
            {
                Console.Clear();
                Console.Write("Enter a number, if you want to end the program enter ok ");
                var input = Console.ReadLine();
                
                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);

                /*Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);*/

            } while (true);

            Console.WriteLine(sum);
        }
    }
}