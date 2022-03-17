using System;
using System.Collections.Generic;

namespace facebook
{
    class Exercises
    {
        public static void Facebook()
        {
            var names = new List<string>();
            do
            {
                Console.Clear();
                Console.Write("Enter names(Leave white space to continue): ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);

            } while (true);

            switch (names.Count)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine("{0} likes your post.", names[0]);
                    break;

                case 2:
                    Console.WriteLine("{0} and {1} likes your post.", names[0], names[1]);
                    break;

                default:
                    Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others likes your post.");
                    break;
            }
        }
        public static void Reverse()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; --i)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine(reversed);
        }
        public static void FiveSort()
        {
            Console.Clear();
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
        public static void Unique()
        {
            Console.Clear();
            var numbers = new List<int>();
            var checkpoint = 0;


            while (true)
            {
                Console.Clear();
                Console.Write("Enter a number(type Quit to exit): ");
                var option = Console.ReadLine();

                if (option.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(option));
            }
            Console.Clear();
            foreach (int number in numbers)
            {
                if(checkpoint != number)
                    Console.WriteLine(number);
                checkpoint = number;
            }
        }
        public static void CommaList()
        {
            Console.Clear();
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}