using System;
using System.Collections.Generic;

namespace strings
{
    public class Exercise
    {
        public static void Consecutive()
        {
            Console.Clear();

            Console.Write("Write a series of numbers separated by hyphen: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Invalid Input.");
                return;
            }

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        public static void Duplicate()
        {
            Console.Clear();

            Console.Write("Write a series of numbers separated by hyphen: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Input.");
                return;
            }

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isDuplicate = false;
            for (int i = 1; i < numbers.Count; ++i)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    isDuplicate = true;
                    break;
                }
            }

            var message = isDuplicate ? "Duplicate" : "Not Duplicate";
            Console.WriteLine(message);
        }

        public static void ValidTime()
        {
            Console.Clear();

            Console.Write("Time Value: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            var hour = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);

            if (0 > hour || hour > 23 || minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Invalid Time.");
            }
            else
                Console.WriteLine("Ok.");
        }

        public static void PascalCase()
        {
            Console.Clear();

            Console.Write("Enter words separated by space: ");
            var input = Console.ReadLine();

            var words = input.ToLower().Split(' ');
            for (var i = 0; i < words.Length; ++i)
            {
                var letters = words[i].ToCharArray();
                var firstLetter = letters[0].ToString().ToUpper();
                
                firstLetter[0].ToString().ToCharArray().CopyTo(letters, 0);

                Console.Write(letters);
            }
            Console.WriteLine();
        }

        public static void VowelsCount()
        {
            Console.Clear();

            Console.Write("Enter a word: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            var count = 0;
            var vowels = new[] {'a', 'e', 'i', 'o', 'u'};
            foreach(var character in input.ToLower())
            {                
                if (Array.Exists(vowels, element => element == character))
                    ++count;
            }
            Console.WriteLine(count);
        }
    }
}