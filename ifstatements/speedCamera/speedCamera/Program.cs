using System;

namespace speedCamera
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the speed limit in km/hr: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Now, enter your car's speed: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("\nOk.");
            }
            else
            {
                const int SpeedPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / SpeedPerDemeritPoint;
                var defaultMessage = "\nYou have " + demeritPoints + " demerit points.";

                switch (demeritPoints)
                {
                    case 12:
                        Console.WriteLine(defaultMessage);
                        Console.WriteLine("License Suspended.");
                        break;
                    
                    default:
                        Console.WriteLine(defaultMessage);
                        break;
                }
            }
        }
    }
}
