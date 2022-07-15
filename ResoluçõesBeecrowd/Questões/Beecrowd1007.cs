using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1007 Diferença
    public class Beecrowd1007
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            var diferenca = ((A * B) - (C * D));
            Console.WriteLine("DIFERENCA = " + diferenca);

        }
    }
}
