using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class FormatStringExample
    {
        public static void Execute()
        {
            //Форматирование
            {
                string name = "Tom";
                int age = 23;
                string output = string.Format("Имя: {0}  Возраст: {1}", name, age);
                Console.WriteLine(output);

                /*
                 * C / c Задает формат денежной единицы, указывает количество десятичных разрядов после запятой
                 * D / d Целочисленный формат, указывает минимальное количество цифр
                 * E / e Экспоненциальное представление числа, указывает количество десятичных разрядов после запятой
                 * F / f Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой
                 * G / g Задает более короткий из двух форматов: F или E
                 * N / n Также задает формат дробных чисел с фиксированной точкой, определяет количество разрядов после запятой
                 * P / p Задает отображения знака процентов рядом с число, указывает количество десятичных разрядов после запятой
                 * X / x Шестнадцатеричный формат числа
                 */

                //Форматирование валюты
                {
                    double number = 23.7;
                    string result = string.Format("{0:C0}", number);
                    Console.WriteLine(result); // 24 р.
                    string result2 = string.Format("{0:C2}", number);
                    Console.WriteLine(result2); // 23,70 р.
                }

                //Форматирование целых чисел
                {
                    int number = 23;
                    string result = string.Format("{0:d}", number);
                    Console.WriteLine(result); // 23
                    string result2 = string.Format("{0:d4}", number);
                    Console.WriteLine(result2); // 0023
                }

                //Форматирование дробных чисел
                {
                    int number = 23;
                    string result = string.Format("{0:f}", number);
                    Console.WriteLine(result); // 23,00

                    double number2 = 45.08;
                    string result2 = string.Format("{0:f4}", number2);
                    Console.WriteLine(result2); // 45,0800

                    double number3 = 25.07;
                    string result3 = string.Format("{0:f1}", number3);
                    Console.WriteLine(result3); // 25,1
                }

                //Проценты
                {
                    decimal number = 0.15345m;
                    Console.WriteLine("{0:P1}", number);// 15,3%
                }

                //Настраиваемые форматы
                {
                    long number = 19876543210;
                    string result = string.Format("{0:+# (###) ###-##-##}", number);
                    Console.WriteLine(result); // +1 (987) 654-32-10
                }
            }

            //Метод ToString
            {
                long number = 19876543210;
                Console.WriteLine(number.ToString("+# (###) ###-##-##"));// +1 (987) 654-32-10

                double money = 24.8;
                Console.WriteLine(money.ToString("C2")); // 24,80 р.
            }

            //Интерполяция строк
            {
                string name = "Tom";
                int age = 23;

                Console.WriteLine($"Имя: {name}  Возраст: {age}");
                // консольный вывод
                // Имя: Tom  Возраст: 23

                int x = 8;
                int y = 7;
                string result = $"{x} + {y} = {x + y}";
                Console.WriteLine(result); // 8 + 7 = 15

                result = $"{x} * {y} = {Multiply(x, y)}";
                Console.WriteLine(result); // 8 * 7 = 56

                int Multiply(int a, int b) => a * b;

                long number = 19876543210;
                Console.WriteLine($"{number:+# ### ### ## ##}"); // +1 987 654 32 10

                //Пространство до и после
                Console.WriteLine($"Имя: {name,-5} Возраст: {age}"); // пробелы после
                Console.WriteLine($"Имя: {name,5} Возраст: {age}"); // пробелы до
            }
        }
    }
}
