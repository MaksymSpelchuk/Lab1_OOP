using System;


class Program
{
    static void Main()
    {
        int num1;
        int num2;
        int num3;

        Console.WriteLine("Введіть перше число");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть третє число");
        num3 = int.Parse(Console.ReadLine());


        int max = Math.Max(num1, Math.Max(num2, num3));
        int min = Math.Min(num1, Math.Min(num2, num3));


        Console.WriteLine("Максимальне число " + max);
        Console.WriteLine("Мінімальне число " + min);
        



    }
}
