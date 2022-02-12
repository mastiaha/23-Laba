using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                Console.Write("Факториал числа {0}\t",n);
                FactorialAsync(n);
                
            }
            else
            {
                Console.WriteLine("Было введено отрицательное число!");
            }
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");

            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int factorial = 1;
            if (n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine(factorial);
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }

    }
}

