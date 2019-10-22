using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppTh
{
    class Analysis
    {
        public static string flag;
        public static void FindFormula()
        {
            var question = ("Повторяются ли элементы в выборке? [+/-]",
                "Важен ли порядок элементов? [+/-]", "Все ли элементы входят в выборку? [+/-]");

            Console.WriteLine($"{question.Item1}");
            
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"{question.Item2}");
                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine($"{question.Item3}");
                            switch (Console.ReadLine())
                            {
                                case "+":
                                    Console.WriteLine("Это перестановки с повторением!");
                                    flag = "pp";
                                    Console.ReadKey();
                                    break;
                                case "-":
                                    Console.WriteLine("Это размещения с повторением!");
                                    flag = "aa";
                                    Console.ReadKey();
                                    break;
                                default: goto case "+";
                            }
                            break;
                        case "-":
                            Console.WriteLine("Это комбинации с повторением!");
                            flag = "cc";
                            Console.ReadKey();
                            break;
                        default: goto case "+";
                    }
                    break;

                case "-":
                    Console.WriteLine($"{question.Item2}");
                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine($"{question.Item3}");
                            switch (Console.ReadLine())
                            {
                                case "+":
                                    Console.WriteLine("Это перестановки!");
                                    flag = "p";
                                    Console.ReadKey();
                                    break;
                                case "-":
                                    Console.WriteLine("Это размещения!");
                                    flag = "a";
                                    Console.ReadKey();
                                    break;
                                default: goto case "+";
                            }
                            break;
                        case "-":
                            Console.WriteLine("Это комбинации!");
                            flag = "c";
                            Console.ReadKey();
                            break;
                        default: goto case "+";
                    }
                    break;

                default: goto case "+";
            }
        }
    }
}
