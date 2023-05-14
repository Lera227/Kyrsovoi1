using System;

namespace MathTreeAlg
{

    internal class Program
    {

        // ---------------  Abbreviated multiplication formulas  ---------------
        public static void SumSquare(int a, int b)
        {
            Console.Write("Результат формулы ");
            Console.WriteLine($"({a} + {b})^2 =  {Math.Pow(a, 2)} + 2*{a}*{b} + {Math.Pow(b, 2)} = {Math.Pow(a + b, 2)}");
            Console.WriteLine($"####################################################################\n" +
                              $"#                              +                                   \n" +
                              $"#                        /            \\                           \n" +
                              $"#                                                                  \n" +
                              $"#                      +                   ^                       \n" +
                              $"#                                       /    \\                    \n" +
                              $"#                /         \\         {b}         2                \n" +
                              $"#              ^             2                                     \n" +
                              $"#           /     \\                                               \n" +
                              $"#         {a}        2                                             \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                               "####################################################################\n");



        }
        public static void SquareOfTheDifference(int a, int b)
        {
            Console.Write("Результат формулы ");
            Console.WriteLine($"({a} - {b})^2 =  {Math.Pow(a, 2)} - 2*{a}*{b} + {Math.Pow(b, 2)} = {Math.Pow(a - b, 2)}");
            Console.WriteLine($"####################################################################\n" +
                              $"#                              +                                   \n" +
                              $"#                        /            \\                           \n" +
                              $"#                                                                  \n" +
                              $"#                      -                   ^                       \n" +
                              $"#                                       /    \\                    \n" +
                              $"#                /         \\         {b}         2                \n" +
                              $"#              ^             2                                     \n" +
                              $"#           /     \\                                               \n" +
                              $"#         {a}        2                                             \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                               "####################################################################\n");
        }
        public static void DifferenceOfSquares(int a, int b)
        {
            Console.Write("Результат формулы ");
            Console.WriteLine($" {a}^2 - {b}^2 = ({a} - {b})*({a} + {b}) = {(a - b) * (a + b)}");
            Console.WriteLine($"####################################################################\n" +
                              $"#                              *                                   \n" +
                              $"#                        /            \\                           \n" +
                              $"#                                                                  \n" +
                              $"#                      +                   -                       \n" +
                              $"#                   /      \\             /    \\                  \n" +
                              $"#                  {a}        {b}           {a}      {b}           \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                               "####################################################################\n");
        }
        //  ---------------  Degree properties  ---------------
        public static void PowerMultiplication(int a, int n, int m)
        {
            Console.Write("Результат формулы ");
            Console.WriteLine($"{a} ^ {n} + {m}  = {(Math.Pow(a, n) * Math.Pow(a, m))}");
            Console.WriteLine($"####################################################################\n" +
                              $"#                              *                                   \n" +
                              $"#                        /            \\                           \n" +
                              $"#                                                                  \n" +
                              $"#                      ^                   ^                       \n" +
                              $"#                   /      \\             /    \\                  \n" +
                              $"#                  {a}        {n}           {a}      {m}           \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                               "####################################################################\n");
        }
        public static void DivisionOfDegrees(int a, int n, int m)
        {
            Console.Write("Результат формулы ");
            Console.WriteLine($"{a} ^ {n} - {m}  = {(Math.Pow(a, n) / Math.Pow(a, m))}");
            Console.WriteLine($"####################################################################\n" +
                              $"#                              /                                   \n" +
                              $"#                        /            \\                           \n" +
                              $"#                                                                  \n" +
                              $"#                      ^                   ^                       \n" +
                              $"#                   /      \\             /    \\                  \n" +
                              $"#                  {a}        {n}           {a}      {m}           \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                               "####################################################################\n");
        }
        public static void Exponentiation(int a, int n, int m)
        {
            Console.Write("Результат формулы ");
            Console.WriteLine($"{a} ^ {n} * {m}  = {Math.Pow(Math.Pow(a, n), m)}");
            Console.WriteLine($"####################################################################\n" +
                              $"#                             {m}                                   \n" +
                              $"#                              |                               \n" +
                              $"#                              ^                                    \n" +
                              $"#                              |                          \n" +
                              $"#                              ^                          \n" +
                              $"#                            /  \\                          \n" +
                              $"#                          {a}   {n}                                    \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                              $"#                                                                  \n" +
                               "####################################################################\n");
        }
        static void Main(string[] args)
        {
            // --------------- Head ---------------
            int a, b, m, n = 0;
            string FistChoice = null;
            string SecondChoice = null;


            // --------------- Body ---------------
            Console.WriteLine("Выберите номер алгоритма:");
            Console.WriteLine("1) Формулы сокращённого умножения\n" +
            "2) Свойства степени ");
            do
            {
                Console.Write("Ваш выбор: ");
                FistChoice = Console.ReadLine();
            } while (FistChoice != "1" && FistChoice != "2" && FistChoice != null);

            Console.WriteLine();
            //Choice case 
            switch (FistChoice)
            {
                case "1":
                    Console.WriteLine("Выберите номер формулы:");
                    Console.WriteLine("1) Квадрат суммы: (a+b)^2 = a^2 + 2*a*b + b^2\n" +
                        "2) Квадрат разности: (a-b)^2 = a^2 - 2*a*b + b^2\n" +
                        "3) Разность квадратов: a^2 - b^2 = (a + b)*(a - b)");
                    do
                    {
                        Console.Write("Ваш выбор: ");
                        SecondChoice = Console.ReadLine();
                    } while (SecondChoice != "1" && SecondChoice != "2" && SecondChoice != "3" && SecondChoice != null);

                    //  Input param
                    Console.WriteLine("\nВведите входные данные a и b");
                   
                        Console.Write("Введите а: ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("Введите b: ");
                        b = int.Parse(Console.ReadLine());
                      
                    // 

                    if (SecondChoice == "1")
                    {
                        SumSquare(a, b);
                    }
                    if (SecondChoice == "2")
                    {
                        SquareOfTheDifference(a, b);
                    }
                    if (SecondChoice == "3")
                    {
                        DifferenceOfSquares(a, b);
                    }
                    break;

                case "2":

                    Console.WriteLine("Выберите номер формулы");
                    Console.WriteLine("1) Произведение степеней: а^m * а^n = a ^ m + n \n" +
                        "2) Частное степеней: а^m / а^n = a ^ m - n \n" +
                        "3) Возведение степени в степень: (а^n)^m = a ^ m * n ");
                    do
                    {
                        Console.Write("Ваш выбор: ");
                        SecondChoice = Console.ReadLine();
                    } while (SecondChoice != "1" && SecondChoice != "2" && SecondChoice != "3" && SecondChoice != null);

                    //  Input param
                    Console.WriteLine("\nВведите входные данные a, n и m");
                    Console.Write("Введите а: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Введите n: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Введите m: ");
                    m = int.Parse(Console.ReadLine());
                    // 
                    if (SecondChoice == "1")
                    {
                        PowerMultiplication(a, n, m);
                    }
                    if (SecondChoice == "2")
                    {
                        DivisionOfDegrees(a, n, m);
                    }
                    if (SecondChoice == "3")
                    {
                        Exponentiation(a, n, m);
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}
