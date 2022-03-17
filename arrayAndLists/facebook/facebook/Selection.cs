using System;

namespace facebook
{
    class Selection
    {
        public void Select()
        {
            Console.WriteLine("Select the exercise.");
            Console.WriteLine("1 - Facebook. ");
            Console.WriteLine("2 - Reverse.");
            Console.WriteLine("3 - FiveSort.");
            Console.WriteLine("4 - Unique.");
            Console.WriteLine("5 - CommaList.");
            Console.WriteLine("0 - Close the application.");
            Console.Write("Type desired exercise: ");

            var exercises = Convert.ToInt32(Console.ReadLine());

            switch (exercises)
            {
                case 1:
                    Exercises.Facebook();
                    break;

                case 2:
                    Exercises.Reverse();
                    break;

                case 3:
                    Exercises.FiveSort();
                    break;

                case 4:
                    Exercises.Unique();
                    break;

                case 5:
                    Exercises.CommaList();
                    break;

                case 0:
                    break;

                default:
                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("Wrong input try again.");
                        Console.WriteLine("\nSelect the exercise: ");
                        Console.WriteLine("1 - Facebook. ");
                        Console.WriteLine("2 - Reverse.");
                        Console.WriteLine("3 - FiveSort.");
                        Console.WriteLine("4 - Unique.");
                        Console.WriteLine("5 - CommaList.");
                        Console.WriteLine("0 - Close the application.");
                        Console.Write("Type desired exercise: ");

                        exercises = Convert.ToInt32(Console.ReadLine());

                        if (exercises == 1)
                        {
                            Exercises.Facebook();
                            break;
                        }


                        else if (exercises == 2)
                        {
                            Exercises.Reverse();
                            break;
                        }

                        else if (exercises == 3)
                        {
                            Exercises.FiveSort();
                            break;
                        }

                        else if (exercises == 4)
                        {
                            Exercises.Unique();
                            break;
                        }

                        else if (exercises == 5)
                        {
                            Exercises.CommaList();
                            break;
                        }

                        else
                            continue;
                    }
                    break;
            }
            Console.WriteLine("\nBye.");
        }
    }
}
