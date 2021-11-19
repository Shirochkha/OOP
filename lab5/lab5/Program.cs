using System;
using System.IO;
using static System.Console;
using System.Text;
using System.Text.RegularExpressions;

namespace lab5
{
    /// <summary>
    /// Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Work with strings and files.
        /// </summary>
        /// <param name="filename">Name of file.</param>
        /// <returns>File exists.</returns>
        static bool PrintFile(string filename)
        {
            StreamReader str;

            // Открыть текстовый файл для чтения
            try
            {
                // Попытка открыть файл для чтения (по умолчанию)
                str = new StreamReader(filename);
            }
            catch (FileNotFoundException e)
            {
                // Если попытка неудачная, то вывести соответствующее сообщение
                WriteLine("Error: {0}", e.Message);
                return false;
            }

            // Цикл чтения строк файла и вывод их на экран
            StringBuilder s; // дополнительная переменная

            WriteLine("Содержимое файла {0}:", filename);

            s = new StringBuilder(str.ReadLine()); // прочитать первую строку из файла
            Regex regex = new Regex(@"\+.*"); //+mlm84
            StringBuilder[] numerous = new StringBuilder[100];
            int i = 0;
            while (!str.EndOfStream) // конец файла - значение null
            {
                // Вывести строку на экран
                WriteLine(s);

                MatchCollection matches = regex.Matches(s.ToString());
                numerous[i] = new StringBuilder(matches[0].Value);
                i++;
                
                // Прочитать следующую строку
                s = new StringBuilder(str.ReadLine());
            }

            WriteLine("\n\tНомера телефонов: ");
            for (int k=0; k<i; k++)
            {
                WriteLine(numerous[k].ToString());
            }

            WriteLine("\n\tСортировка: ");
            for (int k = 0; k < i; k++)
            {
                if (Regex.IsMatch(numerous[k].ToString(), @"\+375"))
                {

                    WriteLine("Беларусь: " + numerous[k].ToString());
                }
                if (Regex.IsMatch(numerous[k].ToString(), @"\+380"))
                {

                    WriteLine("Украина: " + numerous[k].ToString());
                }
                if (Regex.IsMatch(numerous[k].ToString(), @"\+7"))
                {

                    WriteLine("Россия: " + numerous[k].ToString());
                }
                if (Regex.IsMatch(numerous[k].ToString(), @"\+49"))
                {

                    WriteLine("Германия: " + numerous[k].ToString());
                }
            }

            str.Close();

            return true;
        }

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PrintFile("D:\\zayava.txt");
            ReadLine();
        }
    }
}
