using Tyuiu.ShaykhelislamovaDA.Sprint1.Task3.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Арифметические операторы в С#                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу вычисления стоимости покупки, состоящей из           *");
        Console.WriteLine("* нескольких тетрадей и такого же количества обложек к ним.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double a = 2.75;
        double b = 0.5;
        Console.WriteLine("Цена тетради (руб.) -> " + a);
        Console.WriteLine("Цена обложки(руб) -> " + b);
        Console.WriteLine("Необходимое количество тетрадей:");
        int c;
        Console.WriteLine("");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Количество комплектов (шт.) -> " + c);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(a, b, c));
    }
}