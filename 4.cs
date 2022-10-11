using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            third();
            fourth();
        }
        static void first()
        {
            Console.WriteLine("This program evaluate sum of evens in 100");
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine("Even sum in 100: " + sum);
        }

        static void second()
        {
            Console.WriteLine("This program evaluate factorial of N numbers:");
            int N = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            if (N == 0)
            {
                Console.WriteLine("Factorial of 0 equal 0");
                return;
            }
            for (int i = 1; i <= N; i++)
                fact *= i;
            Console.WriteLine("Factorial of " + N + " equal: " + fact);
        }

        static void third()
        {
            Console.WriteLine("This program evaluate function y = Math.Sqrt(1 + Math.Sqrt(3 + Math.Sqrt((2[n]+1))))");
            Console.Write("Give me [n] from above function: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double y = 2 * n + 1;
            for (int i = (2 * n - 1); i >= 1; i -= 2)
                y = (double)i + Math.Sqrt(y);
            y = Math.Sqrt(y);
            Console.WriteLine("The answer is " + y);
        }

        static void fourth()
        {
            Console.WriteLine("N != 0 !!!");
            Console.Write("This program evaluate 'sredniy rost' of N students: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int arifmetic = 0;
            for(int i = 0; i < N; i++)
            {
                Console.Write("Student 'rost': ");
                int student = Convert.ToInt32(Console.ReadLine());
                arifmetic += student;
            }
            Console.WriteLine($"The 'sredniy rost' is {arifmetic/N}");
        }
    }
}
