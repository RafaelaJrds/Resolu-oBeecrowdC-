using System;
using System.Globalization;


namespace ResoluçõesBeecrowd.Questões
{
    //1043 Triângulo
    public class Beecrowd1043
    {
        static void Main(string[] args)
        {

            double x, y, z;
            string[] Valores;
            Valores = Console.ReadLine().Split(' ');
            x = double.Parse(Valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(Valores[1], CultureInfo.InvariantCulture);
            z = double.Parse(Valores[2], CultureInfo.InvariantCulture);


            if (Math.Abs(x - y) < z && (x + y) > z && Math.Abs(z - y) < x && (z + y) > x && Math.Abs(x - z) < y && (x + z) > y)
            {
                double perimetroTriangulo = x + y + z;
                Console.WriteLine("Perimetro = " + perimetroTriangulo.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double areaTrapezio = ((x + y) * z) / 2;
                Console.WriteLine("Area = " + areaTrapezio.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
