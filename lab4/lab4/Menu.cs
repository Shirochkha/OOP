using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lab4
{
    /// <summary>
    /// Show Menu.
    /// </summary>
    class Menu
    {
        /// <summary>
        /// Work with strings.
        /// </summary>
        public static void ShowMenu()
        {
            try
            {
                int flag = 0;

                while (flag != 3)
                {
                    Console.WriteLine("\n\t╔═══════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t║                             МЕНЮ                          ║");
                    Console.WriteLine("\t╟─────┬─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  1  │      Вычислить все арифметические выражения         ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  2  │      Сформировать массив из предложений вида:       ║");
                    Console.WriteLine("\t║     │   Согласная буква \"в\" встречется столько-то раз     ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  3  │                       Выход                         ║");
                    Console.WriteLine("\t╚═══════════════════════════════════════════════════════════╝");

                    flag = Convert.ToInt32(Console.ReadLine());

                    switch (flag)
                    {
                        case 1:
                            Console.WriteLine("\tВведите строку: ");
                            string str = Console.ReadLine();
                            Regex regex = new Regex(@"\b\d+\s?[+/*-]\s?\d+\b"); //доддо 1232 *1331 дрдрд
                            MatchCollection matches = regex.Matches(str);
                            Console.WriteLine("\tВведенная строка: ");
                            Console.WriteLine(str);
                            Console.WriteLine("\tАрифметические выражения: ");
                            foreach (Match k in matches)
                            {
                                string newStr = k.Value.Replace(" ","");
                                Console.WriteLine(newStr);
                                var numbers = newStr.Split(new char[] { '+', '-', '/', '*' });
                                string sign = newStr.Substring(numbers[0].Length, 1);
                                double a = double.Parse(numbers[0]);
                                double b = double.Parse(numbers[1]);
                                double result = 0;
                                switch (sign)
                                {
                                    case "+": result = a + b; break;
                                    case "-": result = a - b; break;
                                    case "*": result = a * b; break;
                                    case "/":
                                        if (b == 0) Console.WriteLine("Деление на 0 невозможно");
                                        else result = a / b; break;
                                }
                                Console.WriteLine("Результат: " + result);
                            }
                            break;
                        case 2:
                            Console.Write("\tВведите текст: ");
                            StringBuilder text = new StringBuilder(Console.ReadLine());
                            regex = new Regex(@"(\.|\?|\!)");
                            matches = regex.Matches(text.ToString());
                            StringBuilder[] newText = new StringBuilder[matches.Count + 1];
                            int kolSent = 0;
                            while(text.Length > 0)
                            {
                                if (text.ToString()[0] == ' ') text.Remove(0, 1);
                                str = text.ToString();
                                if (str.IndexOf(".") > -1 || str.IndexOf("!") > -1 || str.IndexOf("?") > -1)
                                {
                                    int i = 0;
                                    while (str[i] != '.' && str[i] != '!' && str[i] != '?') i++;
                                    str = str.Substring(0, i + 1);
                                }

                                if (Regex.IsMatch(str, $@"^((Гласная|Согласная)\s(буква)\s""[а-яёА-ЯЁ]""\s(встречается)\s\d\s(раз|раза)).*$"))
                                {
                                    newText[kolSent] = new StringBuilder(str);
                                    kolSent++;
                                    text.Remove(0, str.Length);
                                }
                                else
                                {
                                    text.Remove(0, str.Length);
                                }
                            }
                            Console.WriteLine("\nПредложения,подходящие под вид: Согласная буква \"в\" встречется столько-то раз и т.д.\n");
                            for (int i = 0; i < kolSent; i++)
                            {
                                   Console.Write("\n" + newText[i].ToString());
                            }
                            break;
                        case 3:
                            Console.WriteLine("\tПрограмма завершена");
                            break;
                        default:
                            Console.WriteLine("\tТакого пункта меню нет");
                            break;
                    }
                    Console.WriteLine("\tНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
