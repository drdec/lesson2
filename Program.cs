using System;

namespace Lesson1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите минимальную температуру");
            double firstTemperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру");
            double secondTemperature = Convert.ToDouble(Console.ReadLine());

            double averageTemperature = (firstTemperature + secondTemperature) / 2;

            Console.WriteLine($"Средняя температура за сутки равна {averageTemperature}");

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите порядковый номер месяца");

            int monthNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Месяц с таким порядковым номером - {NameOfMonth(monthNumber)}");

            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите число");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число является четным");
            } 
            else
            {
                Console.WriteLine("Число является нечетным");
            }


        }

        private static string NameOfMonth(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "Январь";

                case 2:
                    return "Февраль";

                case 3:
                    return "Март";

                case 4:
                    return "Апрель";

                case 5:
                    return "Май";

                case 6:
                    return "Июнь";

                case 7:
                    return "Июль";

                case 8:
                    return "Август";

                case 9:
                    return "Сентябрь";

                case 10:
                    return "Октябрь";

                case 11:
                    return "Ноябрь";

                case 12:
                    return "Декабрь";

                default:
                    return "неизвестен :)";
            }
        }
    }
}