using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{ 
    //1011 Esfera
    public class Beecrowd1011
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            var volume = (4.0 / 3) * pi * (R * R * R);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
