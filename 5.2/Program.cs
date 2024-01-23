using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int max, min;
            max = 0;
            min = 0;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            max = array[0];
            min = array[0];
            for (int i = 1; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Минимальное число: {0}, максимальное: {1}", min, max);
            Console.WriteLine("Сумма максимального и минимального: {0}", min+max);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
