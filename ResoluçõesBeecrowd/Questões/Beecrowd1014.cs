using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1014 Consumo
    public class Beecrowd1014
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var consumoMedio = X / Y;
            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
