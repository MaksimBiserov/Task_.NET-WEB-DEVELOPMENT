using System;

namespace Task01
{
    class Program
    {
        // функция сортировки, получающая целочисленный массив в качестве аргумента
        // возвращаемым значением функции является строка, содержащая отсортированные по возрастанию элементы
        public static string Sort(int[] arrayInt)
        {
            int temp;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = i + 1; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] > arrayInt[j])
                    {
                        temp = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = temp;
                    }
                }
            }
            string result = "Result:\n";
            for (int i = 0; i < arrayInt.Length; i++)
                result += arrayInt[i].ToString() + " ";

            return result;
            // также возможно использование готовой библиотечной функции языка: статический метод Sort() класса Array
        }
        static void Main(string[] args)
        {
            // демонстрация работы функции
            // вводимые пользователем значения сортируются с помощью метода Sort, результат присваивается строковой переменной
            try
            {
                int[] arrayInt = new int[9];
                Console.WriteLine("Enter 9 numbers:");
                for (int i = 0; i < arrayInt.Length; i++)
                    arrayInt[i] = int.Parse(Console.ReadLine());

                string result = Sort(arrayInt);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}