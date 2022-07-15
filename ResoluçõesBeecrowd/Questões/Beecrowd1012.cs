using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1012 Área
    public class Beecrowd1012
    {
        static void Main(string[] args)
        {
            string[] Valores = Console.ReadLine().Split(' ');
            double A = double.Parse(Valores[0], CultureInfo.InvariantCulture),
                B = double.Parse(Valores[1], CultureInfo.InvariantCulture),
                C = double.Parse(Valores[2], CultureInfo.InvariantCulture);
            var areaTrianguloRetangulo = (A * C) / 2;
            var areaCirculo = (3.14159 * (C * C));
            var areaTrapezio = ((A + B) * C) / 2;
            var areaQuadrado = B * B;
            var areaRetangulo = A * B;
            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
