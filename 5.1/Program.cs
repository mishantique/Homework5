using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            float sum, amount;
            sum = 0;
            amount = 0;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0} элемент", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
                amount++;
            }
            Console.WriteLine("Количество элементов составило {0}. Среднее арифметическое составляет {1}", amount, sum / amount);
            Console.ReadKey();
        }
    }
}
