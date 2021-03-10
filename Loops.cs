using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Loops
    {
        public static void Ex1()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ex2()
        {
            var numbers = new List<float>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number ({i + 1}/5): ");
                var input = Console.ReadLine();

                float num;
                if (!float.TryParse(input, out num)) continue;

                numbers.Add(num);
            }

            Console.WriteLine($"\nAverage: {numbers.Sum() / numbers.Count()}");
        }

        public static void Ex3()
        {
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void Ex4()
        {
            do
            {
                Console.Write("\nEnter 1st number: ");
                var input1 = Console.ReadLine();

                Console.Write("Enter 2nd number: ");
                var input2 = Console.ReadLine();

                Console.WriteLine();

                float num1, num2;

                // If one of the inputs isn't parsable OR if one of the numbers
                // equals zero then `continue` to the next iteration
                if (
                    !float.TryParse(input1, out num1) ||
                    !float.TryParse(input2, out num2) ||
                    num1 == 0 || num2 == 0
                )
                {
                    Console.WriteLine("Continuing...");
                    continue;
                }

                // If one of the numbers is a negative number then stop the loop
                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("Bye.");
                    break;
                }

                Console.WriteLine($"Sum:     {num1 + num2}");
                Console.WriteLine($"Product: {num1 * num2}");
            } while (true);
        }
    }
}
