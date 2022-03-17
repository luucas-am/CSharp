using System;

namespace factorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select the exercise.");
            Console.WriteLine("1 - Factorial. ");
            Console.WriteLine("2 - Random number game.");
            Console.WriteLine("3 - List");
            Console.WriteLine("0 - Close the application.");
            Console.Write("Type desired exercise: ");

            var exercises = Convert.ToInt32(Console.ReadLine());

            switch (exercises)
            {
                case 1:
                    Factorial();
                    break;

                case 2:
                    Random();
                    break;

                case 3:
                    List();
                    break;

                case 0:
                    break;

                default:
                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("Wrong input try again.");
                        Console.WriteLine("\nSelect the exercise: ");
                        Console.WriteLine("1 - Factorial. ");
                        Console.WriteLine("2 - Random number game.");
                        Console.WriteLine("3 - List");
                        Console.WriteLine("0 - Close the application.");
                        Console.Write("Type desired exercise: ");

                        exercises = Convert.ToInt32(Console.ReadLine());

                        if (exercises == 1)
                        {
                            Factorial();
                            break;
                        }


                        else if (exercises == 2)
                        {
                            Random();
                            break;
                        }

                        else if (exercises == 3)
                        {
                            List();
                            break;
                        }

                        else if (exercises == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        
                        else
                            continue;
                    }
                    break;
            }
            Console.WriteLine("\nBye.");
        }

        public static void Factorial()
        {
            Console.Clear();
            
            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            var i = 1;
            do
            {
                factorial *= i;
                ++i;

            } while (i <= input);

            Console.WriteLine("{0}! = {1}", input, factorial);
        }
        private static void Random()
        {
            Console.Clear();
            var random = new Random();

            while (true)
            {
                var randNumber = random.Next(1, 10);

                Console.Write("Enter a number between 1 and 10: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randNumber)
                    break;

                Console.WriteLine("Try again.");
            }

            Console.WriteLine("You Won!");
        }
        static void List()
        {
            Console.Clear();
            Console.Write("Enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var highestNumber = Convert.ToInt32(numbers[0]);

            foreach(var str in numbers)
            {
                var number = Convert.ToInt32(str);
                
                if (highestNumber < number)
                    highestNumber = number;
            }

            Console.WriteLine("Highest number is: " + highestNumber);
        }
    }
}