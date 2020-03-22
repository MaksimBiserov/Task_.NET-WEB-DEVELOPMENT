using System;

namespace Task04
{
    class Program
    {
        // функция нахождения факториала числа n
        // использован тип данных long, в случае переполнения генерируется исключение
        public static long Fact(int n)
        {
            long fact = 1;
            if (n >= 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    checked
                    {
                        fact *= i;
                    }
                }
            }
            return fact;
        }
        static void Main(string[] args)
        {
            // демонстрация работы функции Fact()
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine($"Factorial of this number = {Fact(n)}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}