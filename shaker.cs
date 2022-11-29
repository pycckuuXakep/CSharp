using System;

namespace SortLab
{
    class Program
    {
        static void Main()
        {
            Sort();
        }

        /*Основная программа*/
        static void Sort()
        {
            int[] myint = { 99, 88, 77, 66, 55, 44, 33, 22, 11, 8, 5, 3, 1 };

            WriteArray(myint);
            ShakerSort(myint);
            WriteArray(myint);

            Console.ReadLine();
        }

        /* Шейкер-сортировка */
        static void ShakerSort(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
            Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a)
                Console.Write("{0}|", i.ToString());
            Console.WriteLine("\n\n\n");
        }
    }
}
