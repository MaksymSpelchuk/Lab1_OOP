using System;
using System.ComponentModel.Design;


class Program
{
    static void Main()
    {
        int h;
        Console.WriteLine("Enter a number");
        h = int.Parse(Console.ReadLine());

   
        if (h < 0 || h > 23) 
        {
            Console.WriteLine("Число введено некоректно. Введіть число від 0 до 23");
        }
        else
        {
            if ((h >= 5) && (h <= 10)) 
            {
                Console.WriteLine("Доброго ранку!");
            }
            else if ((h >= 11) && (h <= 16)) 
            {
                Console.WriteLine("Добрий день!");
            }
            else if ((h >= 17) && (h <= 22)) 
            {
                Console.WriteLine("Добрий вечір!");
            }
            else
            {
                Console.WriteLine("Доброї ночі!");
            }
        }

    }
}
    

