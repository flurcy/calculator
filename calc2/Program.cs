using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc2
{
    internal class Program
    {
        static void Plus(int a, int b, out int res) //сумма
        {
            res = a + b;
        }

        static void Minus(int a, int b, out int res) //Разность
        {
            res = a - b;
        }

        static void Mult(int a, int b, out int res) //Умножение
        {
            res = a * b;
        }

        static void Divis(int a, int b, out int res) //Деление
        {
            res = a / b;
        }

        static void Degree(int a, int b, out int res) //Возведение в степень
        {
            res = Convert.ToInt32(Math.Pow(a, b));
        }

        static void Sqrt(int a, out int res) //Извлечение квадратного корня
        {
            res = Convert.ToInt32(Math.Sqrt(a));
        }

        static void Factorial(int a, out int res) //Факториал
        {
            int n = a;  // количество циклов в факториале
            int factorial = 1;   // значение факториала

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            res = factorial;
        }

        static void MR(int a, out int res) //Чистка памяти
        {
            res = a * 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию, над которой требуется провести тест: +, -, *, /, **, sqrt, !, MR");
            string userChoice = Console.ReadLine();

            int res;

            if (userChoice == "+")
            {
                Plus(2, 4, out res);
                if (res == 6)
                {
                    Console.WriteLine("Изначальные значения: 2, 4");
                    Console.WriteLine("Пример: 2+4");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 6");
                    Console.WriteLine("Итог: Тестирование операции сложения прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции сложения прошло неудачно");
                }
            }

            if (userChoice == "-")
            {
                Minus(10, 4, out res);
                if(res == 6)
                {
                    Console.WriteLine("Изначальные значения: 10, 4");
                    Console.WriteLine("Пример: 10-4");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 6");
                    Console.WriteLine("Итог: Тестирование операции вычитания прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции вычитания прошло неудачно");
                }
            }

            if (userChoice == "*")
            {
                Mult(10, 4, out res);
                if (res == 40)
                {
                    Console.WriteLine("Изначальные значения: 10, 4");
                    Console.WriteLine("Пример: 10*4");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 40");
                    Console.WriteLine("Итог: Тестирование операции умножения прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции умножения прошло неудачно");
                }
            }

            if (userChoice == "/")
            {
                Divis(10, 2, out res);
                if (res == 5)
                {
                    Console.WriteLine("Изначальные значения: 10, 2");
                    Console.WriteLine("Пример: 10/2");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 5");
                    Console.WriteLine("Итог: Тестирование операции деления прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции деления прошло неудачно");
                }
            }

            if (userChoice == "**")
            {
                Degree(2, 10, out res);
                if (res == 1024)
                {
                    Console.WriteLine("Изначальные значения: 2, 10");
                    Console.WriteLine("Пример: 2^10");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 1024");
                    Console.WriteLine("Итог: Тестирование операции возведения в степень прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции возведения в степень прошло неудачно");
                }
            }

            if (userChoice == "sqrt")
            {
                Sqrt(4, out res);
                if (res == 2)
                {
                    Console.WriteLine("Изначальное значение: 4");
                    Console.WriteLine("Пример: sqrt(4)");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 2");
                    Console.WriteLine("Итог: Тестирование операции извлечения квадратного корня прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции извлечения квадратного корня прошло неудачно");
                }
            }

            if (userChoice == "!")
            {
                Factorial(5, out res);
                if (res == 120)
                {
                    Console.WriteLine("Изначальное значение: 5");
                    Console.WriteLine("Пример: 5!");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 120");
                    Console.WriteLine("Итог: Тестирование операции факториала прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции факториала прошло неудачно");
                }
            }

            if (userChoice == "MR")
            {
                MR(5, out res);
                if (res == 0)
                {
                    Console.WriteLine("Изначальное значение: 5");
                    Console.WriteLine("Результат: " + res);
                    Console.WriteLine("Ожидаемый результат: 0");
                    Console.WriteLine("Итог: Тестирование операции очистки прошло успешно");
                }
                else
                {
                    Console.WriteLine("Тестирование операции очистки прошло неудачно");
                }
            }

            Console.ReadLine();

            /*
            Plus(1, 2, out res);
            Console.WriteLine(res);
            Console.ReadLine();
            */

        }
    }
}
