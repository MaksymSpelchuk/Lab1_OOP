using System;


class Program
{
    static void Main()
    {
        int number;
        Console.WriteLine("Введіть число");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число " + number + " є  парним числом");
        }
        else
        {
            Console.WriteLine("Число " + number + " є непарним числом");
        }
    }
}
