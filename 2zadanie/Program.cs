using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите a ");
        Double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b ");
        Double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите c ");
        Double c = Convert.ToDouble(Console.ReadLine());
        Double D = (b * b - 4 * a * c);
        if (D < 0)
            Console.WriteLine("нет решений");
        else if (D == 0)
            Console.WriteLine($"x = {-b / (2 * a)}");
        else if (D > 0)
        {
            Console.WriteLine($"x = {(-b + Math.Sqrt(D)) / (2 * a)}");
            Console.WriteLine($"x = {(-b - Math.Sqrt(D)) / (2 * a)}");
        }

    }

}
