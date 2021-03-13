using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace task_1_sorting
{
    class Program
    {
        static public string Comand;
        static void Main(string[] args)
        {
            int dopuslovie;
            double[] arr = new double[24];
            bool arrayEntered = false;
            while (true)
            {
                // Comand = Console.ReadLine();
                //if (Comand == "menu")
                {
                    Console.WriteLine("СПИСОК ДЕЙСТВИЙ");
                    Console.WriteLine("[1] Заполнение массива");
                    Console.WriteLine("[2] Полная сортировка пузырьком");
                    Console.WriteLine("[3] Альтернативная сортировка пузырьком");
                    Console.WriteLine("[4] Выход");
                    Comand = Console.ReadLine();
                    switch (Comand)
                    {

                        case "1": //ввод массива
                            try
                            {
                                Console.WriteLine("Введите 24 чисела");
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    Console.Write("{0}-е число: ", i + 1);
                                    arr[i] = double.Parse(Console.ReadLine());
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Возникла ошибка,вы ввели не число");
                            }
                            arrayEntered = true;
                            break;

                        case "2": //сортировка пузырьком
                            if (arrayEntered)
                            {
                                try
                                {
                                    Console.WriteLine("Выбор направления сортировки");
                                    Console.WriteLine("1. По возрастанию");
                                    Console.WriteLine("2. По убыванию");
                                    Console.WriteLine();
                                    dopuslovie = int.Parse(Console.ReadLine());


                                    if (dopuslovie == 1)
                                    {


                                        // сортировка
                                        double b;
                                        for (int i = 0; i < arr.Length - 1; i++)
                                        {
                                            for (int j = i + 1; j < arr.Length; j++)
                                            {
                                                if (arr[i] > arr[j])
                                                {
                                                    b = arr[i];
                                                    arr[i] = arr[j];
                                                    arr[j] = b;
                                                }
                                            }
                                        }

                                        // вывод
                                        Console.WriteLine("Вывод отсортированного массива");

                                        {
                                            Console.WriteLine("[{0}]", string.Join(", ", arr));
                                        }
                                        Console.ReadLine();
                                    }
                                    else if (dopuslovie == 2)
                                    {
                                        // сортировка
                                        double t;
                                        for (int i = 0; i < arr.Length - 1; i++)
                                        {
                                            for (int j = i + 1; j < arr.Length; j++)
                                            {
                                                if (arr[i] < arr[j])
                                                {
                                                    t = arr[i];
                                                    arr[i] = arr[j];
                                                    arr[j] = t;
                                                }
                                            }
                                        }
                                        // вывод
                                        Console.WriteLine("Вывод отсортированного массива");

                                        {
                                            Console.WriteLine("[{0}]", string.Join(", ", arr));
                                        }
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введенно неизвестное действие");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Возникла ошибка,вы ввели не верную команду");
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Возникла ошибка,вы не заполнили массив");
                            }
                            break;

                        case "3":
                            if (arrayEntered)
                            {
                                for (int k = 0; k < 6; k++)     
                                {
                                    double z;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        for (int j = i + 1; j < 4; j++)
                                            if (((k % 2 == 0) && (arr[k * 4 + i] > arr[k * 4 + j])) || ((k % 2 != 0) && (arr[k * 4 + i] < arr[k * 4 + j])))
                                            {

                                                z = arr[k * 4 + i];
                                                arr[k * 4 + i] = arr[k * 4 + j];
                                                arr[k * 4 + j] = z;
                                            }
                                    }
                                }
                                {

                                    Console.WriteLine("[{0}]", string.Join(", ", arr));

                                }
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Возникла ошибка,вы не заполнили массив");
                            }
                            break;

                        case "4":
                            {
                                Environment.Exit(0);
                            }
                            break;

                        default:
                            Console.WriteLine("Ошибка, ввели не то действие");
                            break;

                    }
                }
            }
        }
    }
}
