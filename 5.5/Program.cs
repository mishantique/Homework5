using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите числo N");

            N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N + 1, N + 1];

            for (int i = 1; i < N + 1; i++)
            {
                for (int j = 1; j < N + 1; j++)
                {
                    if ((i + j) % 2 == 0| i == j | i + j == N + 1)
                    {
                        array[i, j] = 1;
                        Console.Write("{0, 3} ", array[i, j]);
                    }

                    else
                    {
                        array[i, j] = 0;
                        Console.Write("{0, 3} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую кнопку для продолжения");
            Console.ReadKey();
        }
    }
}
