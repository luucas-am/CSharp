using System;

namespace count
{
    class Program
    {
        static void Main()
        {
            var count = 0;
            for (int i = 0; i < 100; ++i)
            {
                if (i % 3 == 0)
                    ++count;
            }
            Console.WriteLine(count);
        }
    }
}
