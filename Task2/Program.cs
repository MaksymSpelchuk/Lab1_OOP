 using System;

class Programm
{
    static void Main()
    {
        double number;
        Console.WriteLine("Введіть дійсне число");
        number = double.Parse(Console.ReadLine());

        double fractionnumber = number - Math.Truncate(number);

        int integernumber = (int)(fractionnumber * 100);

        int firstnumber = integernumber / 10;
        int secondnumber = integernumber % 10;

        int sum = firstnumber + secondnumber;
        Console.WriteLine(sum);
    }
}



