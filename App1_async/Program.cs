using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App1_async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для расчета факториала f!");
            int f = Convert.ToInt32(Console.ReadLine());
            Factorls(f);

            Console.ReadKey();
        }

        static void Factorls(int n)
        {
            int f = 1;
            for (int i = 0; i < n; i++)
            {
                f *= i + 1;
                Thread.Sleep(10);
            }
            Console.WriteLine(f);
        }

        static async void FactorlsAsync(int f)
        {
            await Task.Run(() => Factorls(f));
        }
    }
}
