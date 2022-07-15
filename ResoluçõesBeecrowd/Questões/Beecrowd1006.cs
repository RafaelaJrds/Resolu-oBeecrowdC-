using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1006 Média 2
    public class Beecrowd1006
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var media = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
