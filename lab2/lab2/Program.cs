using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            double S1, S2;
            DefiniteIntegral Integral1 = new DefiniteIntegral(1, 2, 1);
            DefiniteIntegral Integral2 = new DefiniteIntegral(3, 2, 1);
            S1 = CalculationMethod.Rectangle(Integral1);
            S2 = CalculationMethod.Rectangle(Integral2);

            int flag = 0;

            while (flag != 4)
            {
                Console.WriteLine("\n\t╔═══════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t║                             МЕНЮ                          ║");
                Console.WriteLine("\t╟─────┬─────────────────────────────────────────────────────╢");
                Console.WriteLine("\t║  1  │                Перегрузка оператора *               ║");
                Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                Console.WriteLine("\t║  2  │                Перегрузка оператора +               ║");
                Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                Console.WriteLine("\t║  3  │           Результат вычисления интегралов           ║");
                Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                Console.WriteLine("\t║  4  │                       Выход                         ║");
                Console.WriteLine("\t╚═══════════════════════════════════════════════════════════╝");

                flag = Convert.ToInt32(Console.ReadLine());
                switch (flag)
                {
                    case 1:
                        Console.WriteLine("Сумма интегралов: {0}", Integral1 * 5);
                        break;
                    case 2:
                        Console.WriteLine("Сумма интегралов: {0}", Integral1 + Integral2);
                        break;
                    case 3:
                        Console.WriteLine("Площадь 1 интеграла равна: {0}", S1);
                        Console.WriteLine("Площадь 2 интеграла равна: {0}", S2);
                        Console.ReadKey();
                        break;
                    case 4:
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
    }
}
