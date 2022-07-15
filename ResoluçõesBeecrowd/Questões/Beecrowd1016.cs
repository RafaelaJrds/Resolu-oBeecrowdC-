using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1016 Distância
    public class Beecrowd1016
    {
        static void Main(string[] args)
        {

            int distancia = int.Parse(Console.ReadLine());
            int minutos = (60 * distancia) / 30;

            Console.WriteLine(minutos + " minutos");
        }
    }
}
