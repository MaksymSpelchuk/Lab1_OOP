using System;


class Program
{
    static void Main()
    {
        int celsia;

        Console.WriteLine("Введіть температуру в градусах Цельсія");
        celsia = Convert.ToInt32(Console.ReadLine());


        int farengeit = (celsia * 9 / 5) + 32;
        Console.WriteLine("Температура в градусах Фаренгейта: " + farengeit);
        

    }
}
