using Tyuiu.ShaykhelislamovaDA.Sprint1.Task4.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Class Math                                                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (1 - cos(a)) / (sin(a))^2 и печатает его *");
        Console.WriteLine("* на экране.                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double a;
        Console.WriteLine("Введите значение угла а(в радианах):");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(a));


    }
}