using System;
namespace ConsoleApplication1

{
    public class Calculator
    {
        
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
            public int sumLastNums(int a)
            {
                int r = ((a % 10) + ((a / 10) % 10));
                return r;
            }

            public bool isPositive(int b)
            {
                if (b > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool isUpperCase(char x)
            {
                if (x >= 'A' && x <= 'Z')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool isDivisor(int a, int b)
            {
                if ((a % b == 0) || (b % a == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int lastNumSum(int a, int b)
            {
                return  (a % 10) + (b % 10);
            }

            public double safeDiv(int x, int y)
            {
                if (y != 0)
                {
                    return (x / y);
                }
                else
                {
                    return 0;
                }
            }

            public string makeDecision(int x, int y)
            {
                if (x>y)
                {
                    return (x + " > " + y);
                }

                if (x < y)
                {
                    return (x + " < " + y);
                }

                if (x == y)
                {
                    return (x + " == " + y);
                }

                return string.Empty;
            }
            public bool sum3(int x, int y, int z)
            {
                if ((x + y == z) || (z + y == x) || (z + x == y))
                    return true;
                else 
                    return false;
            }

            public string age(int x)
            {
                if ((x % 10) == 1)
                {
                    return (x + " год");
                }
                
                if (((x % 10) == 2) || ((x % 10) == 3) || ((x % 10) == 4))
                {
                    return (x + " года");
                }
                if (((x% 100) == 12) || ((x% 100) == 13) || ((x% 100) == 14))
                {
                    return (x + " лет");
                }
                else
                {
                    return (x + " лет");
                }
            }

            public void printDays(string x)
            {
                switch (x)
                {
                    case "понедельник":
                        Console.WriteLine("понедельник");
                        goto case "вторник";
                    case "вторник":
                        Console.WriteLine("вторник");
                        goto case "среда";
                    case "среда":
                        Console.WriteLine("среда");
                        goto case "четверг";
                    case "четверг":
                        Console.WriteLine("четверг");
                        goto case "пятница";
                    case "пятница":
                        Console.WriteLine("пятница");
                        goto case "воскресенье";
                    case "воскресенье":
                        Console.WriteLine("воскресенье");
                        break;
                    default:
                        Console.WriteLine("это не день недели");
                        break;
                }
            }

            public string reverseListNums(int x)
            {
                string result = "";

                for (int i = x; i >= 0; i--)
                {
                    result += " " + i;
                }

                return result;
            }

            public int pow(int x, int y)
            {
                int result = 1;

                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }

                return result;
            }
            public bool equalNum(int x)
            {
                int firstDigit = x % 10;
                
                while (x != 0)
                {
                    int currentDigit = x % 10;
                    
                    if (currentDigit != firstDigit)
                    {
                        return false;
                    }

                    x = x / 10;
                }
                return true;
            }
            public void leftTriangle(int x)
            {
                for (int row = 1; row <= x; row++)
                {
                    for (int i = 0; i < row; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public void guessGame()
            {
                Random random = new Random();
                int secret = random.Next(0, 10);

                int attempts = 0;
                bool guessed = false;

                while (!guessed)
                {
                    int j = ReadIntFromConsole("Введите число от 0 до 9");

                    attempts += 1;
                    if (secret == j)
                    {
                        Console.WriteLine("Вы угадали за " + attempts + " попыток");
                            guessed = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
                    }
                }
            }
            
            public int findLast(int[] arr, int x)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] == x)
                    {
                        return i;
                    }
                }
                return -1;
            }
    }
}