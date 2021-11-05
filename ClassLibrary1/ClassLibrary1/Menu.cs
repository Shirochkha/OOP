using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Class Menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Show Menu.
        /// </summary>
        public static void ShowMenu()
        {
            try
            {
                Parallelogram A = Parallelogram.Create();
                Console.Clear();
                if (A.IsExist() == true)
                {
                    Console.WriteLine("\tНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();

                    int flag = 0;

                    while (flag != 6)
                    {
                        Console.WriteLine("\n\t╔═══════════════════════════════════════════════════════════╗");
                        Console.WriteLine("\t║                             МЕНЮ                          ║");
                        Console.WriteLine("\t╟─────┬─────────────────────────────────────────────────────╢");
                        Console.WriteLine("\t║  1  │             Создать новый параллелограмм            ║");
                        Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                        Console.WriteLine("\t║  2  │               Периметр параллелограмма              ║");
                        Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                        Console.WriteLine("\t║  3  │               Площадь параллелограмма               ║");
                        Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                        Console.WriteLine("\t║  4  │           Проверить принадлежность точки            ║");
                        Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                        Console.WriteLine("\t║  5  │       Проверить существование параллелограмма       ║");
                        Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                        Console.WriteLine("\t║  6  │                      Выход                          ║");
                        Console.WriteLine("\t╚═══════════════════════════════════════════════════════════╝");

                        flag = Convert.ToInt32(Console.ReadLine());
                        switch (flag)
                        {
                            case 1:
                                A = Parallelogram.Create();
                                Console.WriteLine("\tПараллелограмм создан");
                                break;
                            case 2:
                                Console.WriteLine($"\tПериметр: {A.PerimetrCalculation()}");
                                break;
                            case 3:
                                Console.WriteLine($"\tПлощадь: {A.SquareCalculation()}");
                                break;
                            case 4:
                                Parallelogram.CheckPointAffiliation(A);
                                break;
                            case 5:
                                A.IsExist();
                                break;
                            case 6:
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

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
