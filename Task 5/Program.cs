using System;
using System.Formats.Asn1;

class Program
{
    static void Main()
    {
        double length;
        double width;

        Console.WriteLine("Введіть довжину");
        length = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть ширину");
        width = double.Parse(Console.ReadLine());


        double area = length * width;
        Console.WriteLine("Площа прямокутника: " + area);

    }
}
