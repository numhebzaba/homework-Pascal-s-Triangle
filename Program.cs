using System;

namespace homework_Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            if (floor>=0)
            {
                for (int i= 0; i <= floor; i++)
                {
                    for(int j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                        Console.Write(Combination(i, j));
                        Console.Write(" ");

                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Invalid Pascal’s triangle row number.");
            }
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static int Combination(int n,int r)
        {
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }
    }
}
