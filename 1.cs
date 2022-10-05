using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fourth();
        }

        static void first()
        {
            Console.WriteLine("Give me num of month and I say what season.");
            Console.WriteLine("Num of months: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("WINTER");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("SPRINT");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("SUMMER");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("AUTUMN");
                    break;
                default:
                    Console.WriteLine("Are you seriously?");
                    break;
            }
        }

        static void second()
        {
            Console.WriteLine("Give me num of month and I say how many days in it.");
            Console.WriteLine("Num of month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine("28");
                    break;
            }
        }

        static void third()
        {
            Console.WriteLine("Give me two's nums and operation: <fnum> <operation> <snum> = result");
            Console.WriteLine("<snum> != 0, bcs division on zero is error");
            Console.Write("<fnum>: ");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("<operation>: ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.Write("<snum>: ");
            int snum = Convert.ToInt32(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.WriteLine($"{fnum} {oper} {snum} = {fnum + snum}");
                    break;
                case '-':
                    Console.WriteLine($"{fnum} {oper} {snum} = {fnum - snum}");
                    break;
                case '*':
                    Console.WriteLine($"{fnum} {oper} {snum} = {fnum * snum}");
                    break;
                case '/':
                    Console.WriteLine($"{fnum} {oper} {snum} = {fnum / snum}");
                    break;
            }
        }

        static void fourth()
        {
            Console.WriteLine("Give me num of day in week");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }
    }
}   
