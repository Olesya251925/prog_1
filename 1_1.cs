using System;

class Program
{
    static void Main()
    {
        // Ввод значений a, b, y1 и y2
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите значение y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Проверка, чтобы y1 было больше или равно y2
        if (y1 >= y2)
        {
            // Проверка, чтобы a было отличным от нуля
            if (a != 0)
            {
                // Вычисление x1 и x2
                double x1 = (y1 - b) / a;
                double x2 = (y2 - b) / a;

                // Вывод промежуточных результатов с форматированием
                Console.WriteLine($"x1 равно {x1:F2}");
                Console.WriteLine($"x2 равно {x2:F2}");

                // Вычисление Xk
                double Xk = (x1 + x2) / 2;

                // Проверка, чтобы Xk не был отрицательным
                if (Xk >= 0)
                {
                    // Округление Xk до двух знаков после запятой
                    Xk = Math.Round(Xk, 2);

                    Console.WriteLine($"Xk равно {Xk}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Xk не может быть отрицательным.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: a не может быть равно нулю.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: y1 должно быть больше или равно y2.");
        }

        Console.ReadLine();
    }
}
