using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Strings
{
    internal class StringBuilderExample
    {
        public static void Execute()
        {
            //Создание
            {
                StringBuilder sb = new StringBuilder();
                sb = new StringBuilder("Привет мир");

                Console.WriteLine(sb);

                string str = sb.ToString();
                
            }

            //Длина и ёмкость
            {
                StringBuilder sb = new StringBuilder("Привет мир");
                Console.WriteLine($"Длина: {sb.Length}");       // Длина: 10
                Console.WriteLine($"Емкость: {sb.Capacity}");   // Емкость: 16
            }

            //Преимущества StringBuilder
            {
                var sb = new StringBuilder("Название: ");
                Console.WriteLine(sb);   // Название: 
                Console.WriteLine($"Длина: {sb.Length}"); // 10
                Console.WriteLine($"Емкость: {sb.Capacity}"); // 16

                sb.Append(" Руководство");
                Console.WriteLine(sb);   // Название: Руководство
                Console.WriteLine($"Длина: {sb.Length}"); // 22
                Console.WriteLine($"Емкость: {sb.Capacity}"); // 32

                sb.Append(" по C#");
                Console.WriteLine(sb);   // Название: Руководство по C#
                Console.WriteLine($"Длина: {sb.Length}"); // 28
                Console.WriteLine($"Емкость: {sb.Capacity}"); // 32
            }

            //Append, Replace, Remove
            {
                var sb = new StringBuilder("Привет мир");
                sb.Append("!");
                sb.Insert(7, "компьютерный ");
                Console.WriteLine(sb);  // Привет компьютерный мир!

                // заменяем слово
                sb.Replace("мир", "world");
                Console.WriteLine(sb);  // Привет компьютерный world!

                // удаляем 13 символов, начиная с 7-го
                sb.Remove(7, 13);
                Console.WriteLine(sb);  // Привет world!

                // получаем строку из объекта StringBuilder
                string text = sb.ToString();
                Console.WriteLine(text);    // Привет world!
            }

            /*
             * Microsoft рекомендует использовать класс String в следующих случаях:
             * При небольшом количестве операций и изменений над строками
             * При выполнении фиксированного количества операций объединения. В этом случае компилятор может объединить все операции объединения в одну
             * Когда надо выполнять масштабные операции поиска при построении строки, например IndexOf или StartsWith. Класс StringBuilder не имеет подобных методов.
             * 
             * Класс StringBuilder рекомендуется использовать в следующих случаях:
             * При неизвестном количестве операций и изменений над строками во время выполнения программы
             * Когда предполагается, что приложению придется сделать множество подобных операций
             */

        }
    }
}
