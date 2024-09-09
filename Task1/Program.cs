using System.Formats.Asn1;
using System.Threading.Channels;
class Programm
{
    static void Main()
    {
        int day;
        int months;

        Console.WriteLine("Enter a number of day: ");
        day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number of month: ");
        months = Convert.ToInt32(Console.ReadLine()); 

        if ((months > 0) && (months < 13))
        {
            if (months == 2)
            {
                if ((day > 0) && (day < 29))
                    Console.WriteLine("True");
                else if (true)
                    Console.WriteLine("False");
            }
            else if ((months == 1) || (months == 3) || (months == 5) || (months == 7) || (months == 8) || (months == 10) || (months == 12))
            {
                if ((day > 0) && (day < 32))
                    Console.WriteLine("True");
                else if (true)
                    Console.WriteLine("False");
            }
            else if ((months == 4) || (months == 6) || (months == 9) || (months == 11))
            {
                if ((day > 0) && (day < 31))
                    Console.WriteLine("True");
                else if (true)
                    Console.WriteLine("False");
            }
        }

        else if (true)
            Console.WriteLine("False");
    }

}