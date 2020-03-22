using System;

namespace Task02
{
    class Program
    {
        // функция, определяющая, содержится ли в отсортированном целочисленном массиве заданное значение
        // в случае нахождения выводится подтверждающее сообщение и функция возвращает true
        // иначе функция возвращает false
        public static bool Search(int[] array, int setValue)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i] == setValue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The value is FOUND in the array");
                    Console.ResetColor();
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            // демонстрация работы функции Search()
            // если заданное значение не содержится в массиве, срабатывает блок catch
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int setValue;
            try
            {
                setValue = 5;
                Search(array, setValue);
                setValue = 10;
                Search(array, setValue);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The value was NOT FOUND in the array");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}