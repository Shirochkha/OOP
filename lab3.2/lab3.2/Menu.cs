using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /// <summary>
    /// Show Menu.
    /// </summary>
    class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Введите размерность массива A");
            Array1D arrayA = new Array1D(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\tМассив A");
            arrayA.InputFloatArray();

            Console.WriteLine("Введите размерность массива B");
            Array1D arrayB = new Array1D(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\tМассив B");
            arrayB.InputFloatArray();

            Console.WriteLine("Введите размерность массива C");
            Array1D arrayC = new Array1D(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\tМассив C");
            arrayC.InputFloatArray();

            try
            {
                int flag = 0;

                while (flag != 4)
                {
                    Console.Write("Массив A: ");
                    arrayA.ShowFloatArray();
                    Console.Write("Массив B: ");
                    arrayB.ShowFloatArray();
                    Console.Write("Массив C: ");
                    arrayC.ShowFloatArray();

                    Console.WriteLine();

                    Console.WriteLine("\n\t╔═══════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t║                             МЕНЮ                          ║");
                    Console.WriteLine("\t╟─────┬─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  1  │   Количество отрицательных элементов массива A*C    ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  2  │  Количество отрицательных элементов массивов A и C  ║");
                    Console.WriteLine("\t║     │           после элемента с заданным номером         ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║     │   Если в массиве A*B есть отрицательные элементы,   ║");
                    Console.WriteLine("\t║     │   превышающие -5.3, сформировать массив из 500      ║");
                    Console.WriteLine("\t║  3  │   элементов, в котором все элементы с номерами,     ║");
                    Console.WriteLine("\t║     │   кратными 10, равны 0, а остальные равны 1         ║");
                    Console.WriteLine("\t╟─────┼─────────────────────────────────────────────────────╢");
                    Console.WriteLine("\t║  4  │                       Выход                         ║");
                    Console.WriteLine("\t╚═══════════════════════════════════════════════════════════╝");

                    flag = Convert.ToInt32(Console.ReadLine());

                    switch (flag)
                    {
                        case 1:
                            Console.WriteLine("\tРезультат: {0}", (arrayA*arrayC).Count());
                            break;
                        case 2:
                            Console.WriteLine("\tВведите номер элемента");
                            int num = Convert.ToInt32(Console.ReadLine());
                            if ((num < arrayA.Length) && (num < arrayC.Length))
                            {
                                Console.WriteLine("\tРезультат: {0} и {1}", arrayA.Count(num), arrayC.Count(num));
                            }
                            else
                            {
                                Console.WriteLine("\tЭлемент превышает размерность массива");
                            }
                            break;
                        case 3:
                            if((arrayA * arrayB).Count((float)-5.3) > 0)
                            {
                                Array1D arrayD = 500;
                                for(int i=0; i<500; i++)
                                {
                                    if(i%10 == 0)
                                    {
                                        arrayD[i] = 0;
                                    }
                                }
                                Console.Write("\tРезультат : ");
                                arrayD.ShowFloatArray();
                            }
                            else
                            {
                                Console.WriteLine("\tВ массиве A*B нет отрицательных элементов, превышающих -5.3");
                                (arrayA* arrayB).ShowFloatArray();
                            }    
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

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
