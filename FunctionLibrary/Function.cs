using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class Function
    {
        public void CalculateFunction(double k, double N, int iterations)
        {
            try
            {
                int currentIteration = 0;

                for (double x = 0; x <= k+1; x += 0.1)
                {
                    double result = 0.0;

                    if (Math.Abs(x - N) == 0)
                    {
                        throw new DivideByZeroException("Ошибка: Деление на ноль");
                    }
                    else
                    { 
                        result = 1 / (x - N);
                        if (x>k && currentIteration < iterations)
                        {
                            throw new OverflowException("Ошибка: Переполнение диапазона");
                        }
                      
                        Console.WriteLine($"При x = {x:F1}, f(x) = {result:F2}");
                    }

                    currentIteration++;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }
        }
    }
}
