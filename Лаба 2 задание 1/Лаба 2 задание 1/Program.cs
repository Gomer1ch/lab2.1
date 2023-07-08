using System;

namespace Лаба_2_задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("1-Алгебра; 2-Иностранный язык; 3-Программирование; 4-Украинский язык; 5-Мат.Анализ");
            Console.Write("Введите номер дисциплины:");
           A:try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch { Console.Write("Ошибка. Введите номер дисциплины:"); goto A; };
            switch(x)
            {
                case 1:
                    Console.WriteLine("Алгебра - Экзамен");
                    break;
                case 2:
                    Console.WriteLine("Иностранный язык - Зачет");
                    break;
                case 3:
                    Console.WriteLine("Программирование - Зачет");
                    break;
                case 4:
                    Console.WriteLine("Украинский язык - Зачет");
                    break;
                case 5:
                    Console.WriteLine("Мат.Анализ - Экзамен");
                    break;
                default:
                    Console.WriteLine("Такого предмета нет");
                    break;
            }
            Console.ReadKey();
        }
    }
}
