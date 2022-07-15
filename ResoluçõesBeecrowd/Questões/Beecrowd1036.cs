using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões
{
    //1036 Fómula de Bhaskara
    public class Beecrowd1036
    {
        static void Main(string[] args)
        {
            string[] Valores = Console.ReadLine().Split(' ');
            double A = double.Parse(Valores[0], CultureInfo.InvariantCulture),
                   B = double.Parse(Valores[1], CultureInfo.InvariantCulture),
                   C = double.Parse(Valores[2], CultureInfo.InvariantCulture);

            if ((A == 0) || (B * B - 4 * A * C < 0))
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }
            double bhaskara = Math.Sqrt(B * B - 4 * A * C);
            double R1 = (-B + bhaskara) / (2 * A);
            double R2 = (-B - bhaskara) / (2 * A);
            Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
