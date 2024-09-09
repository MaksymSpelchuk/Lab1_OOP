using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть натуральне число:");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("Сума перших " + n + " чисел дорівнює: " + sum);
        


    }
}
