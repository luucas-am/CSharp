using System;

namespace random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                try
                {
                    Console.Write("Min Number: ");
                    var min = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Max Number: ");
                    var max = Convert.ToInt32(Console.ReadLine());

                    if(min > max)
                        throw new Exception();

                    Console.Write("Repeat Count: ");
                    var count = Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i < count; i++)
                    {
                        var random = new Random().Next(min, max+1);
                        Console.WriteLine(random);
                    }

                    System.Console.Write("\nRepeat (Y/N): ");
                    var repeat = Convert.ToChar(Console.ReadLine().ToLower());
                    if(repeat != 'y' && repeat != 'n')
                        throw new Exception();
                    else if(repeat == 'n')
                        break;
                }
                catch(Exception)
                {
                    System.Console.WriteLine("\nInvalid Input.\nPress Any Key.");
                    Console.ReadKey();
                }

            }
        }
    }
}
