using System;

namespace DNC_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num < 5)
            {
                Console.WriteLine("Running contents of the while loop");
                num++;

                if (num == 3)
                {
                    Console.WriteLine("If statement is true, and now exiting the while loop");
                    break;
                }
            }

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine($"{i} is an odd number");
            }

            Console.ReadLine();
        }
    }
}
