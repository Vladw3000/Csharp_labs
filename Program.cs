using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static int[] ReadArray()
        {
            int length = ReadIntFromConsole("Введите размер массива");
            int[] arr = new int[length];
    
            for (int i = 0; i < length; i++)
            {
                arr[i] = ReadIntFromConsole("Введите элемент массива №" + i);
            }
    
            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            Console.Write("Ответ: [");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        private static int ReadIntFromConsole(string prompt)
        {
            int result;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка ввода, введите коректное число");
            }
        }
        
        private static char ReadCharFromConsole(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (input.Length==1)
                {
                    return input[0];
                }
                Console.WriteLine("Ошибка ввода, введите одну букву");
            }
        }
        
        static void Main(string[] args)
        {
            bool IsRuning = true;
            
            while (IsRuning)
            {
                Calculator calc = new Calculator();
                
                Console.WriteLine("----------------------------");
                Console.WriteLine("Лабораторная работа номер 1");
                Console.WriteLine("1. Задание 1: Сложение послендих двух чисел");
                Console.WriteLine("2. Задание 2: Проверка на положительность");
                Console.WriteLine("3. Задание 3: Проверка на Верхний регистр");
                Console.WriteLine("4. Задание 4: Проверка на деление нацело другого любым из чисел");
                Console.WriteLine("5. Задание 5: Сумма 2 цифр из двух чисел из разряда единиц 5 раз подряд");
                Console.WriteLine("6. Задание 6: Деление первого числа на второе");
                Console.WriteLine("7. Задание 7: Сравнение 2 чисел");
                Console.WriteLine("8. Задание 8: Сложение 3 чисел");
                Console.WriteLine("9. Задание 9: Год, года или лет");
                Console.WriteLine("10. Задание 10: Дни недели до конца недели");
                Console.WriteLine("11. Задание 11: Отсчёт до 0");
                Console.WriteLine("12. Задание 12: Возведение в степень");
                Console.WriteLine("13. Задание 13: Одинаковые цифры");
                Console.WriteLine("14. Задание 14: Треугольник из звезд");
                Console.WriteLine("15. Задание 15: Угадайка");
                Console.WriteLine("16. Задание 16: Поиск последнего значения");
                Console.WriteLine("17. Задание 17: Добавление в массив");
                Console.WriteLine("18. Задание 18: Реверс");
                Console.WriteLine("19. Задание 19: Объединение масивов");
                Console.WriteLine("20. Задание 20: Удалить негатив");
                Console.WriteLine("0. Выход из программы");
                Console.WriteLine("Выберете номер задания:");
                Console.WriteLine("----------------------------");
                
                string imput = Console.ReadLine();

                switch (imput)
                {
                    case "1":
                        int a = ReadIntFromConsole("Введите число");
                        int b = calc.sumLastNums(a);
                        Console.WriteLine("Ответ: " + b);
                        break;
                    case "2":
                        int c = ReadIntFromConsole("Введите число");
                        bool d = calc.isPositive(c);
                        Console.WriteLine("Ответ: " + d);
                        break;
                    case "3":
                        char e = ReadCharFromConsole("Введите Букву");
                        bool f = calc.isUpperCase(e);
                        Console.WriteLine("Ответ: " + f);
                        break;
                    case "4":
                        int g = ReadIntFromConsole("Введите два числа");
                        int g2 = ReadIntFromConsole("Введите число");
                        bool h = calc.isDivisor(g,g2);
                        Console.WriteLine("Ответ: " + h);
                        break;
                    case "5":
                        int currentSum = 0;
                        for (int i = 0; i<5; i++)
                        {
                            int q = ReadIntFromConsole("Введите число");
                            currentSum = calc.lastNumSum(currentSum, q);
                        }
                        Console.WriteLine("Ответ: " + currentSum);
                        break;
                    case "6":
                        int t = ReadIntFromConsole("Введите два числа");
                        int t2 = ReadIntFromConsole("Введите число");
                        double w = calc.safeDiv(t,t2);
                        Console.WriteLine("Ответ: " + w);
                        break;
                    case "7":
                        int r = ReadIntFromConsole("Введите два числа");
                        int r2 = ReadIntFromConsole("Введите число");
                        string y = calc.makeDecision(r,r2);
                        Console.WriteLine("Ответ: " + y);
                        break;
                    case "8":
                        int u = ReadIntFromConsole("Введите два числа");
                        int u2 = ReadIntFromConsole("Введите число");
                        int u3 = ReadIntFromConsole("Введите число");
                        bool o = calc.sum3(u,u2,u3);
                        Console.WriteLine("Ответ: " + o);
                        break;
                    case "9":
                        int p = ReadIntFromConsole("Введите число");
                        string s = calc.age(p);
                        Console.WriteLine("Ответ: " + s);
                        break;
                    case "10":
                        Console.WriteLine("Напишите с маленькой буквы день недели");
                        string j = Console.ReadLine();
                        calc.printDays(j);
                        break;
                    case "11":
                        int l = ReadIntFromConsole("Введите число");
                        string z = calc.reverseListNums(l);
                        Console.WriteLine("Ответ: " + z);
                        break;
                    case "12":
                        int x = ReadIntFromConsole("Введите число");
                        int x2 = ReadIntFromConsole("Введите число");
                        int v = calc.pow(x,x2);
                        Console.WriteLine("Ответ: " + v);
                        break;
                    case "13":
                        int n = ReadIntFromConsole("Введите число");
                        bool m = calc.equalNum(n);
                        Console.WriteLine("Ответ: " + m);
                        break;
                    case "14":
                        int a1 = ReadIntFromConsole("Введите число");
                        calc.leftTriangle(a1);
                        break;
                    case "15":
                        calc.guessGame();
                        break;
                    case "16":
                    {
                        int[] arr = ReadArray();
                        int x1 = ReadIntFromConsole("Введите число для поиска");
                        int index = calc.FindLast(arr, x1);
                        Console.WriteLine("Ответ: " + index);
                        break;
                    }
                    case "17":
                    {
                        int[] arr = ReadArray();
                        int x3 = ReadIntFromConsole("Введите число для вставки");
                        int pos = ReadIntFromConsole("Введите позицию для вставки");
                        int[] newArr = calc.Add(arr, x3, pos);
                        PrintArray(newArr);
                        break;
                    }
                    case "18":
                    {
                        int[] arr = ReadArray();
                        calc.Reverse(arr);
                        PrintArray(arr);
                        break;
                    }
                    case "19":
                    {
                        Console.WriteLine("--- Введите первый массив ---");
                        int[] arr1 = ReadArray();
                        Console.WriteLine("--- Введите второй массив ---");
                        int[] arr2 = ReadArray();
                        int[] res = calc.Concat(arr1, arr2);
                        PrintArray(res);
                        break;
                    }
                    case "20":
                    {
                        int[] arr = ReadArray();
                        int[] res = calc.DeleteNegative(arr);
                        PrintArray(res);
                        break;
                    }
                    case "0":
                        IsRuning = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка: Введите коректное значение");
                        break;
                }
            }
        }
    }
}