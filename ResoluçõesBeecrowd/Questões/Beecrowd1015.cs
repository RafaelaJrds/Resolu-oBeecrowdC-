using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1015 Distância entre dois pontos
    public class Beecrowd1015
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture),
                   y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            string[] p2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture),
                   y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

            var distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
