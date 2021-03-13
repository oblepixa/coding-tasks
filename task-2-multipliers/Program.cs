using System;

namespace task_2_multipliers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a;
                int b;
                int c;
                Console.WriteLine("Введите 3 значения для расчёта");
                try
                {
                    a = Convert.ToInt16(Console.ReadLine());
                    b = Convert.ToInt16(Console.ReadLine());
                    c = Convert.ToInt16(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели ненедопустимое значение");
                    continue;
                }
                if (a < 0 || b < 0 || c < 0)
                {
                    Console.WriteLine("Нельзя вводить отрицательные значения");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("НОК=" + NOK(a, b, c));
                    Console.WriteLine("НОД=" + NOD(a, b, c));
                }

            }
        }
        static double NOK(double a, double b, double c)
        {
            double s = a * b * c;
            for (int i = 1; i <= s; i++)
            {
                if ((i % a == 0) && (i % b == 0) && (i % c == 0))
                {
                    return i;
                }
            }
            return s;
        }
        static double NOD(int a, int b, int c)
        {
            int Nod = Math.Min(a, Math.Min(b, c));
            for (; Nod > 1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            return Nod;
        }
    }
}
