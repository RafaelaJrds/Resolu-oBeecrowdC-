using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1005 Média1
    public class Beecrowd1005
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var media = ((A * 3.5) + (B * 7.5)) / 11;
            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
