using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double element, sum_line, sum_column, sum_diag1, sum_diag2;
            sum_line = 0 ; 
            sum_column = 0;
            sum_diag1 = 0 ;
            sum_diag2 = 0 ;

            Console.WriteLine("Введите целое число N");
            N = Convert.ToInt32(Console.ReadLine());

            double[,] array = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Введите элемент {0} строки {1} столбца", i+1, j+1);
                    element = Convert.ToDouble(Console.ReadLine());
                    array[i, j] = element;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum_line += array[i, j];

                    if (i == j)
                    {
                        sum_diag1 += array[i, j];
                    }
                    if (i + j == N - 1)
                    {
                        sum_diag2 += array[i, j];
                    }

                    sum_column += array[j, i];
                }
            }
            Console.WriteLine("По всем строкам {0}, по главной {1}, по побочной {2}, по всем столбцам {3}", sum_line, sum_diag1, sum_diag2, sum_column);
            if (sum_column / 3 == sum_line / 3 && sum_diag1 == sum_diag2 && sum_diag1 == sum_column / 3)
            {
                Console.WriteLine("{0} = {1} = {2} = {3}. Матрица - магический квадрат", sum_column / 3, sum_line / 3, sum_diag1, sum_diag2);
            }

            else
            {
                Console.WriteLine("Матрица не является магическим квадратом");
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
