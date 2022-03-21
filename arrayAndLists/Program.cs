using System;

namespace arrayAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("[1] - Facebook\n[2] - Reverse\n[3] - Sort");
                Console.WriteLine("[4] - Unique\n[5] - Smallest Numbers\n[0] - Close the Application");
                Console.Write("Select the Exercise: ");
                var input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Exercises.Facebook();
                        break;

                    case 2:
                        Exercises.Reverse();
                        break;

                    case 3:
                        Exercises.Sort();
                        break;

                    case 4:
                        Exercises.Unique();
                        break;

                    case 5:
                        Exercises.SmallestNumbers();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("ERROR - Invalid Input.");
                        break;
                }
                Console.Write("Press Any To Continue.");
                Console.ReadKey();
            }
        }
    }
}
