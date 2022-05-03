﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class BasicStringExamples
    {
        public static void Execute()
        {
            {
                string s1 = "hello";
                string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
                string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
                string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

                Console.WriteLine(s1);  // hello
                Console.WriteLine(s2);  // aaaaaaa
                Console.WriteLine(s3);  // world
                Console.WriteLine(s4);  // orl


                //Строка как набор символов
                string message = "hello";
                // получаем символ
                char firstChar = message[1]; // символ 'e'
                Console.WriteLine(firstChar);   //e

                Console.WriteLine(message.Length);  // длина строки 

                //Перебор строк
                for (var i = 0; i < message.Length; i++)
                {
                    Console.WriteLine(message[i]);
                }
                foreach (var ch in message)
                {
                    Console.WriteLine(ch);
                }

                //Сравнение строк
                string message1 = "hello";
                string message2 = "hello";

                Console.WriteLine(message1 == message2);    // true
            }

            //Объединение строк
            {
                string s1 = "hello";
                string s2 = "world";
                string s3 = s1 + " " + s2; // результат: строка "hello world"
                string s4 = string.Concat(s3, "!!!"); // результат: строка "hello world!!!"

                Console.WriteLine(s4);

                string s5 = "apple";
                string s6 = "a day";
                string s7 = "keeps";
                string s8 = "a doctor";
                string s9 = "away";
                string[] values = new string[] { s5, s6, s7, s8, s9 };

                string s10 = string.Join(" ", values);
                Console.WriteLine(s10); // apple a day keeps a doctor away
            }

            //Сравнение строк
            {
                string s1 = "hello";
                string s2 = "world";

                int result = string.Compare(s1, s2);
                if (result < 0)
                {
                    Console.WriteLine("Строка s1 перед строкой s2");
                }
                else if (result > 0)
                {
                    Console.WriteLine("Строка s1 стоит после строки s2");
                }
                else
                {
                    Console.WriteLine("Строки s1 и s2 идентичны");
                }
                // результатом будет "Строка s1 перед строкой s2"
            }

            //Поиск в строке
            {
                string s1 = "hello world";
                char ch = 'o';
                int indexOfChar = s1.IndexOf(ch); // равно 4
                Console.WriteLine(indexOfChar);

                string substring = "wor";
                int indexOfSubstring = s1.IndexOf(substring); // равно 6
                Console.WriteLine(indexOfSubstring);

                var files = new string[]
                {
                    "myapp.exe",
                    "forest.jpg",
                    "main.exe",
                    "book.pdf",
                    "river.png"
                };

                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].EndsWith(".exe"))
                        Console.WriteLine(files[i]);
                }
            }

            //Разделение строк
            {
                //Неудачный вариант, могут появиться пустые строки
                {

                    string text = "И поэтому все так произошло";

                    string[] words = text.Split(new char[] { ' ' });

                    foreach (string s in words)
                    {
                        Console.WriteLine(s);
                    }
                }

                //Вариант лучше
                {
                    string text = "И поэтому все так произошло";

                    string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string s in words)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            //Обрезка строки
            {
                //Trim
                {
                    string text = " hello world ";

                    text = text.Trim(); // результат "hello world"
                    text = text.Trim(new char[] { 'd', 'h' }); // результат "ello worl"
                }

                //Substring
                {
                    string text = "Хороший день";
                    // обрезаем начиная с третьего символа
                    text = text.Substring(2);
                    // результат "роший день"
                    Console.WriteLine(text);
                    // обрезаем сначала до последних двух символов
                    text = text.Substring(0, text.Length - 2);
                    // результат "роший де"
                    Console.WriteLine(text);
                }
            }

            //Вставка
            {
                string text = "Хороший день";
                string substring = "замечательный ";

                text = text.Insert(8, substring);
                Console.WriteLine(text);    // Хороший замечательный день
            }

            //Удаление строк
            {
                string text = "Хороший день";
                // индекс последнего символа
                int ind = text.Length - 1;
                // вырезаем последний символ
                text = text.Remove(ind);
                Console.WriteLine(text);    // Хороший ден

                // вырезаем первые два символа
                text = text.Remove(0, 2);
                Console.WriteLine(text);    // роший ден
            }

            //Замена
            {
                string text = "хороший день";

                text = text.Replace("хороший", "плохой");
                Console.WriteLine(text);    // плохой день

                text = text.Replace("о", "");
                Console.WriteLine(text);    // плхй день
            }

            //Смена регистра
            {
                string hello = "Hello world!";

                Console.WriteLine(hello.ToLower()); // hello world!
                Console.WriteLine(hello.ToUpper()); // HELLO WORLD!
            }
        }
    }
           
}
