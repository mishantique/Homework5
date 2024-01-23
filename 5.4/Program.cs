using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            bool flag_nechet = false;
            bool flag_polozhit = false;
            bool flag_place = false;
            int counter = 0;
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 ==0)
                {
                    flag_nechet = true;
                }

                if (array[i] > 0)
                {
                    flag_polozhit = true;
                }

                if ((i + 1) % 2 == 0)
                {
                    flag_place = true;
                }

                if (!flag_place || !flag_nechet || !flag_polozhit)
                {
                    counter++;
                }
            }
            if (counter != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Количество составило {0} ", counter);
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Искомых элементов нет");
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
    }
}
