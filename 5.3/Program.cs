using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    for (int j = 0; j < (n / 2) - 1; j ++)
                    {
                        for (int k = j + 1; k < (n / 2); k++) 
                        {
                            if (array[k] <= array[j])
                            {
                                int x;
                                x = array[k];
                                array[k] = array[j];
                                Console.WriteLine("Поменяли {0} с {1}. Первая половина", x, array[j]);
                                array[j] = x;
                            }

                            else
                            {
                                continue;
                            }
                        }
                    }
                }

                else
                {
                    for (int j = n/2; (j < n); j++)
                    {
                        for (int k = j+1; k < n; k++)
                        {
                            if (array[k] >= array[j])
                            {
                                int x;
                                x = array[k];
                                array[k] = array[j];
                                Console.WriteLine("Поменяли {0} с {1}. Вторая половина", x, array[j]);
                                array[j] = x;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0} ", array[l]);
            }
            Console.ReadKey();
        }
    }
}
