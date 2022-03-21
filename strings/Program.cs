using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("[1] - Consecutive\n[2] - Duplicate\n[3] - Valid Time");
                    Console.WriteLine("[4] - Pascal Case\n[5] - Vowels Count\n[0] - Close Application");
                    Console.Write("Select Exercise: ");
                    var input = Convert.ToInt32(Console.ReadLine());

                    switch(input)
                    {
                        case 1:
                            Exercise.Consecutive();
                            break;

                        case 2:
                            Exercise.Duplicate();
                            break;

                        case 3:
                            Exercise.ValidTime();
                            break;

                        case 4:
                            Exercise.PascalCase();
                            break;

                        case 5:
                            Exercise.VowelsCount();
                            break;

                        case 0:
                            return;

                        default:
                            System.Console.WriteLine("ERROR - Invalid Input.");
                            break;
                    }
                    System.Console.WriteLine("Press Any Key To Continue.");
                    Console.ReadKey();
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid Input.\nPress Any Key To Continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}
