using System;
using System.Text;

namespace LP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isLiza = true;

            byte bit1 = 1;
            sbyte bit2 = -1;

            short short1 = -123;
            ushort short2 = 123;

            int int1 = -1000;
            uint int2 = 1000;

            long long1 = -100000000;
            ulong long2 = 100000000;

            float float1 = 3.14f;
            double double1 = 3.1414d;
            decimal decimal1 = 3.14141414m;

            char char1 = 'c';
            string string1 = "12345";

            object o1 = 1;
            object o2 = 'j';
            object o3 = -3.14m;         

            //Операции неявного приведения

            short a1 = bit1;
            int a2 = short1;
            long a3 = int1;
            float a4 = long1;
            double a5 = float1;

            //Операции явного приведения

            int b1 = (int)double1;
            decimal b2 = (decimal)float1;
            char b3 = (char)bit1;
            byte b4 = (byte)char1;
            long b5 = (long)decimal1;

            //Упаковка и распаковка значимых типов

            int c1 = 1;
            object c2 = c1;
            int c3 = (int)c2;

            string d1 = "string";
            object d2 = d1;
            string d3 = (string)d2;

            //Неявно типизированные переменные

            var i1 = 1;
            var i2 = 2;
            var i3 = i1 + i2;
            Console.WriteLine($"---Неявно типизированные переменны:\nСумма i1 ({i1}) и i2 ({i2}) равна {i3}\n");
           
            //Nullable

            int? f1 = null;
            int? f2 = 5;

            if(f1.HasValue)
            {
                Console.WriteLine($"---Nullable:\nЗначение переменной f1 равно {f1.Value}");
            }
            else
            {
                Console.WriteLine($"---Nullable:\nПеременная f1 не имеет значения");
            }

            if (f2.HasValue)
            {
                Console.WriteLine($"Значение переменной f2 равно {f2.Value}");
            }
            else
            {
                Console.WriteLine($"Переменная f2 не имеет значения");
            }

            Console.WriteLine("\n"+ "-----------------------------------------"+"\n");

            //Строковые литералы: сравнение
            Console.WriteLine($"---Сравнение строк:");

            string g1 = "Hello1";
            string g2 = "Hello1";
            string g3 = "Hello2";

            if(String.Compare(g1, g2)>0)
            {
                Console.WriteLine($"Первая строка {g1} следует за второй {g2} в порядке сортировки или вторая строка {g2} имеет значение null."); ; ;
            }
            else  if (String.Compare(g1, g2) < 0)
            {
                Console.WriteLine($"Вторая строка {g2} следует за первой {g1} в порядке сортировки или первая строка {g1} имеет значение null.");
            }
            else
            {
                Console.WriteLine("Строки идентичны.");
            }

            if (String.Compare(g1, g3) > 0)
            {
                Console.WriteLine($"Первая строка {g1} следует за второй {g3} в порядке сортировки или вторая строка {g3} имеет значение null."); ; ;
            }
            else if (String.Compare(g1, g3) < 0)
            {
                Console.WriteLine($"Вторая строка {g3} следует за первой {g1} в порядке сортировки или первая строка {g1} имеет значение null.");
            }
            else
            {
                Console.WriteLine("Строки идентичны.");
            }

            if (String.Compare(g3, g1) > 0)
            {
                Console.WriteLine($"Первая строка {g3} следует за второй {g1} в порядке сортировки или вторая строка {g1} имеет значение null."); ; ;
            }
            else if (String.Compare(g3, g1) < 0)
            {
                Console.WriteLine($"Вторая строка {g1} следует за первой {g3} в порядке сортировки или первая строка {g3} имеет значение null.");
            }
            else
            {
                Console.WriteLine("Строки идентичны.");
            }

            Console.WriteLine();
            Console.WriteLine($"Идентичны ли строки g1 ({g1}) и g2 ({g2})? " + (String.Equals(g1, g2)));
            Console.WriteLine($"Идентичны ли строки g1 ({g1}) и g3 ({g3})? " + (String.Equals(g1, g3)));
            Console.WriteLine("\n" + "-----------------------------------------" + "\n");

            //Строковые литералы: склеивание

            Console.WriteLine($"---Склеивание строк:");
            string k1 = "Hello";
            string k2 = "World";
            string k3 = "!";
            Console.WriteLine("Вариант 1: " + k1 + " " + k2 + k3);
            Console.WriteLine("Вариант 2: " + (String.Concat(k1, " ", k2, k3, "\n")));

            //Строковые литералы: копирование

            Console.WriteLine($"---Копирование строк:");

            string k4 = String.Copy(k2+k3);
            string k5 = String.Copy(k2 + k3);
            Console.WriteLine(k1 + " " + k4);
            Console.WriteLine(k1 + " " + k5 + "\n");

            //Строковые литералы: выделение подстроки

            Console.WriteLine($"---Выделение подстроки:");

            string l1 = "TestString";
            char l2 = 'T';
            string l3 = "trin";
            int l4 = l1.IndexOf(l2);
            int l5 = l1.IndexOf(l3);

            Console.WriteLine($"Символ \"{l2}\" в строке \"{l1}\", считая с начала строки, стоит на {l4} позиции.");
            Console.WriteLine($"Символ \"{l2}\" в строке \"{l1}\", считая с конца строки, стоит на {l5} позиции." + "\n");

            //Строковые литералы: разделение строки на слова

            Console.WriteLine($"---Разделение строки на слова:");

            string text = "String for test";
            Console.WriteLine("Исходная строка: " + text + "\nРезультат:");
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //Строковые литералы: вставки подстроки в заданную позицию

            Console.WriteLine("\n---Вставки подстроки в заданную позицию:");

            string text1 = "There is here.";
            string text2 = "an apple ";
            Console.WriteLine("Исходная строка: " + text1 + "\nДобавляем: " + text2);
            Console.WriteLine("Результат: " + text1.Insert(9, text2) + "\n");

            //Строковые литералы: удаление заданной подстроки

            Console.WriteLine("\n---Удаление заданной подстроки:");

            string text3 = "Str ing";
            string text4 = text3.Remove(3, 1);
            Console.WriteLine($"Было \"{text3}\", стало \"{text4}\"\n");

            //Пустая и null строки

            Console.WriteLine("\n---Пустая и null строки:");

            string text5 = "";
            string text6 = null;
            string text7 = text5 + text6;
            Console.WriteLine("Строка text5 пуста? " + String.IsNullOrEmpty(text5));
            Console.WriteLine("Строка text6 пуста? " + String.IsNullOrEmpty(text6));
            Console.WriteLine("Строка text7 пуста? " + String.IsNullOrEmpty(text6));

            //StringBuilder

            Console.WriteLine("\n---StringBuilder:");

            StringBuilder text8 = new StringBuilder("Hello");
            text8.Append(" my");
            text8.Append(" dear World");

            Console.WriteLine(text8);

            int length = text8.Length;
            Console.WriteLine("Длина строки: " + length);

            text8.Insert(0,"!!! ");
            Console.WriteLine(text8);
            text8.Append(" !!!");
            Console.WriteLine(text8);

            text8.Remove(10,8);
            Console.WriteLine(text8);

            Console.WriteLine("\n" + "-----------------------------------------" + "\n");

            //Массивы

            Random rand = new Random();

            Console.WriteLine("---Двумерный массив:");
            int[,] numbers = new int[5, 5];
            for (int i = 0; i < 5 ; i++)
            {
                for (int j = 0; j < 5 ; j++)
                {
                    numbers[i, j] = rand.Next(0, 9);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n---Одномерный массив:");
            int[] numbers1 = new int[5];
            for(int i=0; i < numbers1.Length; i++)
            {
                numbers1[i] = rand.Next(0, 9);
                Console.Write(numbers1[i] + " ");
            }
            Console.WriteLine($"\n\nВведите индекс(от 0 до {numbers1.Length - 1}): ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите значение: ");
            int value = Convert.ToInt32(Console.ReadLine());
            numbers1[index] = value;
            Console.WriteLine("\n---Изменённый одномерный массив:");
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers1[i] + " ");
            }

            Console.WriteLine("\n\n---Ступенчатый массив:");

            //Ступенчатый массив 

            int[][] numbers2 = new int[3][];
            numbers2[0] = new int[2];
            numbers2[1] = new int[3];
            numbers2[2] = new int[4];

            int[] numbers3 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                numbers3[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            int x = 0;
            for (int num = 0; num < 2; num++)
            {
                 numbers2[0][num] = numbers3[x];
                 Console.Write("{0}\t", numbers2[0][num]);
                x++;
            }
            Console.WriteLine();
            for (int num = 0; num < 3; num++)
            {
                 numbers2[1][num] = numbers3[x];
                 Console.Write("{0}\t", numbers2[1][num]);
                x++;
            }
            Console.WriteLine();
            for (int num = 0; num < 4; num++)
            {
                 numbers2[2][num] = numbers3[x];
                 Console.Write("{0}\t", numbers2[2][num]);
                x++;
            }

            //Неявно типизированные переменные для хранения массива и строки

            Console.WriteLine("\n\n---Неявно типизированные переменные для хранения массива и строки:");

            var a = new[] { 1, 2, 3, 4 };
            var b = new[] { "Hello", "world", "!!!" };

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}\t", b[i]);
            }

            Console.WriteLine("\n\n" + "-----------------------------------------" + "\n");

            //Кортежи
            Console.WriteLine("---Кортежи:\n");

            (int, string, char, string, ulong) kortej = (5, "Liza", 'L', "Kubik", 100);
            Console.WriteLine("Кортеж kortej: " + kortej + "\n");
            Console.WriteLine($"Первый элемент: {kortej.Item1}, третий элемент: {kortej.Item3} и четвёртый элемент:  {kortej.Item4}\n");

            (int s1, string s2, char s3, string s4, ulong s5) kortej1 = kortej;
            //kortej1 = (int, string, char, string, ulong)temp;
            Console.WriteLine(kortej1);

            Console.WriteLine("\nКортежи kortej и kortej1 равны? " + (kortej == kortej1));

            (int, float, string) localFunc((int, float) parTuple)
            {
                string str11 = "abc";
                return (parTuple.Item1, parTuple.Item2, str11);
            }

            var tuple = (firstValue: 5, secondValue: 4.123f);


            (int, float, string) newTuple = localFunc(tuple);

            /*Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых и строка.
              Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, сумму
              элементов массива и первую букву строки . */

            Console.WriteLine("\n---Локальная функция:\n");
            int[] arr1 = new int[5];
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(1, 5);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            string str1 = "hello";
            Console.WriteLine("Исходная строка: " + str1);

            (int, int, int, string)func1(int[] arr, string str)
            {
                int max = arr[0];
                int min = arr[0];
                int sum = 0;
                string subStr = str.Substring(0,1);

                for(int i=0; i<arr.Length; i++)
                {
                    if(arr[i]>max)
                    {
                        max = arr[i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                return (max, min, sum, subStr);
            }

            Console.WriteLine("Максимальное значение: " + func1(arr1, str1).Item1 + ", минимальное: " + func1(arr1, str1).Item2 + ", сумма: " + func1(arr1, str1).Item3 + ", первая буква строки : " + func1(arr1, str1).Item4 + ".\n");
        }
    }
}
