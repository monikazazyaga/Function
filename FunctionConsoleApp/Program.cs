using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace FunctionConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение k:");
            double k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение N:");
            double N = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество итераций:");
            int iterations = Convert.ToInt32(Console.ReadLine());

            FunctionLibrary.Function function = new FunctionLibrary.Function();
            function.CalculateFunction(k, N, iterations);
        }
    }
}
