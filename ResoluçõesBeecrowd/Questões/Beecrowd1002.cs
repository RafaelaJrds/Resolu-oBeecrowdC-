using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    public class Beecrowd1002
    //1002	Área do Círculo
    {

        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n = 3.14159;
            var area = n * (r * r);
            Console.WriteLine("A=" + (area).ToString("F4", CultureInfo.InvariantCulture));

        }

    }
}
    

