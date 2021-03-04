using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите число, операцию и второе число через Enter");

                try
                {
                    Console.WriteLine("Ответ: " + Calculate(
                            Convert.ToDouble(Console.ReadLine()),
                            Convert.ToChar(Console.ReadLine()),
                            Convert.ToDouble(Console.ReadLine())
                        )
                    );
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль невозможно");
                    Console.ReadLine();
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте ещё раз!");
                    Console.ReadLine();
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели недопустимую операцию, попробуйте ещё раз!");
                    Console.ReadLine();
                    continue;
                }

            }
        }
        static double Calculate(double x, char oper, double y)
        {
            switch (oper)
            {
                case '+':
                    return Add(x, y);

                case '-':
                    return Subtract(x, y);

                case '*':
                    return Multiply(x, y);

                case '/':
                    if (y == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return Divide(x, y);

                case '^':
                    return Power(x, y);

                default:
                    throw new Exception();
            }

        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            return x / y;
        }
        static double Power(double x, double y)
        {
            return x * x;
        }

    }
}