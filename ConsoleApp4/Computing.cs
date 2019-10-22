using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppTh
{
    class Computing
    {
        public static void Calculate()
        {
            Console.WriteLine("Введите, из скольких (для перестановок с повторением - общее кол-во элементов):");

            int num = ManageInputCorrectness();
            
            switch (Analysis.flag)
            {
                case "pp":
                    Console.WriteLine("Введите количество различных элементов ряда:");
                    int j = ManageInputCorrectness();
                    Console.WriteLine("Введите по порядку, сколько раз повторяется в ряду каждый элемент:");
                    var denominator = 1;
                    for (var i = 0; i < j; i++)
                    {
                        int input = ManageInputCorrectness();
                        denominator *= Factorial(input);
                    }
                    Console.WriteLine($"Результат: {Factorial(num) / denominator}");
                    Console.ReadKey();
                    break;
                case "p":
                    Console.WriteLine($"Результат: {Factorial(num)}");
                    Console.ReadKey();
                    break;
                case "aa":
                    Console.WriteLine("Введите, по сколько:");
                    var k = ManageInputCorrectness();
                    if (k >= num) goto case "aa";
                    Console.WriteLine($"Результат: {Math.Pow(num, k)}");
                    Console.ReadKey();
                    break;
                case "a":
                    Console.WriteLine("Введите, по сколько:");
                    k = ManageInputCorrectness();
                    if (k >= num) goto case "a";
                    Console.WriteLine($"Результат: {Factorial(num) / Factorial(num - k)}");
                    Console.ReadKey();
                    break;
                case "cc":
                    Console.WriteLine("Введите, по сколько:");
                    k = ManageInputCorrectness();
                    if (k >= num) goto case "cc";
                    Console.WriteLine($"Равносильно комбинациям из {k} по {num + k - 1}");
                    Console.WriteLine($"Результат: {Factorial(num + k - 1) / (Factorial(num - 1) * Factorial(k))}");
                    Console.ReadKey();
                    break;
                case "c":
                    Console.WriteLine("Введите, по сколько:");
                    k = ManageInputCorrectness();
                    if (k >= num) goto case "c";
                    Console.WriteLine($"Результат: {Factorial(num) / (Factorial(num - k) * Factorial(k))}");
                    Console.ReadKey();
                    break;
            }
        }

        public static int Factorial(int x)
        {
            if (x == 1 || x == 0) return 1;
            return x * Factorial(x - 1);
        }

        public static int ManageInputCorrectness()
        {
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int num))
            {
                if (num > 0)
                return Convert.ToInt32(input);
            }

            Console.WriteLine("Введите корректное число");
            return ManageInputCorrectness();
        }

        public static void IsSolvingNeeded()
        {
            Console.WriteLine("Решим задачку? [+/-]");
            var p = Console.ReadLine();
            if (p == "+" || string.IsNullOrEmpty(p))
            {
                Analysis.FindFormula();
                Calculate();
            }

            else if (p == "-") return;

            else IsSolvingNeeded();
        }
            
    }
    
}

