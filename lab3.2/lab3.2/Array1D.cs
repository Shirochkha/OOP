using System;
using System.Collections.Generic;

namespace Arrays
{
    public class Array1D
    {

        private float[] floatArray;

        //длина массива
        public int Length
        {
            get { return floatArray.Length; }
        }

        //индексатор
        public float this[int index]
        {
            get { return floatArray[index]; }
            set { floatArray[index] = value; }
        }

        //конструктор по умолчанию
        public Array1D()
        {
            floatArray = new float[5];
        }

        //конструктор с парметрами
        public Array1D(int length)
        {
            floatArray = new float[length];
        }

        // Метод, позволяющий ввести элементы массива с клавиатуры.
        //parse - считывает введеную строку и преобразует в вещественное число.
        public void InputFloatArray()
        {
            Console.WriteLine("Введите элименты массива: ");
            for (int i = 0; i < floatArray.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                floatArray[i] = float.Parse(Console.ReadLine());
            }
        }

        // Метод, позволяющий вывести элементы массива на экран.
        public void ShowFloatArray()
        {
            foreach (float item in floatArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        //Количество отрицательных элементов во всем массиве.
        public int Count()
        {
            int minus = 0;
            for (int i = 0; i < Length; i++)
            {
                if (this[i] < 0)
                {
                    minus++;
                }
            }
            return minus;
        }

        //Количество отрицательных элементов после элемента с заданным номером.
        public int Count(int num)
        {
            int minus = 0;
            for (int i = 0; i < Length; i++)
            {
                if ((i > num) && (this[i] < 0))
                {
                    minus++;
                }
            }
            return minus;
        }

        //Количество отрицательных элементов, больших заданного
        public int Count(float number)
        {
            int minus = 0;
            for (int i = 0; i < Length; i++)
            {
                if ((this[i] > number) && (this[i] < 0))
                {
                    minus++;
                }
            }
            return minus;
        }

        //Умножение массивов.
        public static Array1D operator *(Array1D a, Array1D b)
        {
            Array1D newArray = new Array1D(Math.Max(a.Length, b.Length));

            if (a.Length > b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    newArray[i] = a[i] * b[i];
                }

                for (int i = b.Length; i < a.Length; i++)
                {
                    newArray[i] = a[i];
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    newArray[i] = a[i] * b[i];
                }

                for (int i = a.Length; i < b.Length; i++)
                {
                    newArray[i] = b[i];
                }
            }

            return newArray;
        }

        //Операция неявного преобразования целого числа в объект класса.
        public static implicit operator Array1D(int x)
        {
            Array1D newArray = new Array1D(x);

            for (int i = 0; i < x; i++)
            {
                newArray[i] = 1;
            }

            return newArray;
        }
    }
}