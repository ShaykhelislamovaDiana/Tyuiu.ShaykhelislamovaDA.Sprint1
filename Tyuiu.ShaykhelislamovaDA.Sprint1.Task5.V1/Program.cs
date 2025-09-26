using Tyuiu.ShaykhelislamovaDA.Sprint1.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Преобразование типов и класс Convert                                    *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
        Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1, x2, y1, y2;
        Console.WriteLine("Введите значние координаты x1:");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значние координаты y1:");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значние координаты x2:");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значние координаты y2:");
        y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2)));
    }
}