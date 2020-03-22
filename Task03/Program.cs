using System;

namespace Task03
{
    class Program
    {
        // метод, проверяющий наличие разделителя
        static bool CheckSeparator(char ch)
        {
            if (ch == ' ' || ch == '.' || ch == ',')
                return true;
            return false;
        }

        // метод, считающий количество слов в строке
        public static int GetWordCount(string str)
        {
            int sizeWords = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (CheckSeparator(str[i]))
                    sizeWords++;
            }
            return sizeWords;
        }

        // метод для извлечения слов
        public static string Substring(string str, int startIndex, int count)
        {
            char[] word = new char[count];
            int index = 0;
            for (int i = startIndex; i < startIndex + count; i++)
            {
                word[index] = str[i];
                index++;
            }
            return new string(word);
        }

        // метод, выполняющий подсчет вхождения слова и выводящий на экран слово, которое имеет вхождение 1 раз
        static void CountAndPrint(string[] words)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                        count++;
                }
                if (count == 1)
                    Console.WriteLine(words[i]);
                count = 0;
            }
        }

        // метод, выполняющий вывод на экран неповторяющихся слов
        static void PrintSingleWords(string str)
        {
            string[] words = new string[GetWordCount(str)];// Получить кол-во слов

            // Разделить на слова
            int startIndex = 0;
            int wordIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                // Проверить на разделитель, выделить слово и добавть его в массив
                if (CheckSeparator(str[i]))
                {
                    if (startIndex != 0)
                    {
                        startIndex++;
                    }
                    string word = Substring(str, startIndex, i - startIndex);
                    words[wordIndex] = word;
                    startIndex = i;
                    wordIndex++;
                }
            }
            // Посчитать вхождение слова и напечатать слово которое имеет вхождение 1 раз
            CountAndPrint(words);
        }

        // демонстрация работы программы
        static void Main(string[] args)
        {
            string str = "hello hello world.";
            PrintSingleWords(str);
            str = "one two three four five four three two one.";
            PrintSingleWords(str);
            Console.ReadKey();
        }
    }
}