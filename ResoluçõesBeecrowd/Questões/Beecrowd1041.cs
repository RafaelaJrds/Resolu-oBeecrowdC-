using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões
{
    //1041 Coordenadas de um ponto
    public class Beecrowd1041
    {
        static void Main(string[] args)
        {

            double x, y;
            string[] Valores;
            Valores = Console.ReadLine().Split(' ');
            x = double.Parse(Valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(Valores[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");

            }
            else if (x == 0 && y == 0)
            {

                Console.WriteLine("Origem");

            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Eixo X");
            }






        }
    }
}
