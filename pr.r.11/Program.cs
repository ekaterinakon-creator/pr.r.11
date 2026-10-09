//***********************************************************************
//* Практическая работа № 11                                            *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
namespace pr.r._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try // поиск ошибок
                {
                    Console.Title = "Практическая работа №11";
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Здравствуйте!");
                    string str;
                    Console.WriteLine("Введите любую строку: ");
                    str = Convert.ToString(Console.ReadLine());
                    if (String.IsNullOrEmpty(str))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Строка пустая. Вы ничего не ввели! ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        int counta = 0;
                        int counto = 0;
                        for (int i = 0; i < str.Length; i++)
                        {
                            char lowerchar = char.ToLower(str[i]);
                            if (lowerchar == 'a' || lowerchar == 'а') // а англ и рус
                            {
                                counta++;
                            }
                            else if (lowerchar == 'o' || lowerchar == 'о') // о англ и рус
                            {
                                counto++;
                            }
                        }
                        Console.WriteLine($"количество о в строке = {counto}");
                        Console.WriteLine($"количество а в строке = {counta}");
                    }
                    bool rightСhoice = false; // флаг: ввел ли пользователь корректное значение
                    while (!rightСhoice)
                    {
                        try
                        {
                            Console.WriteLine("\nХотите выполнить программу еще раз? (0 - да, 1 - нет)");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice) // проверка выбранного значения
                            {
                                case 0:
                                    rightСhoice = true;
                                    break; // программа запустится заново
                                case 1:
                                    return; // выход из программы
                                default:

                                    break;
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Возникла ошибка: " + fex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                }
                catch (Exception ex) // обработка исключения
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}