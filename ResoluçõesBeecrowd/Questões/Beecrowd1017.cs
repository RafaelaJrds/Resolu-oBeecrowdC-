using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1017 Gasto de combustível
    public class Beecrowd1017
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());
            double distanciaKm = tempo * velocidade;
            double gastoLitros = distanciaKm / 12;

            Console.WriteLine(gastoLitros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
