using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões
{
    // 1044 Múltiplos
    public class Beecrowd1044
    {
        static void Main(string[] args)
        {

            int x, y;
            string[] Valores;
            Valores = Console.ReadLine().Split(' ');
            x = int.Parse(Valores[0]);
            y = int.Parse(Valores[1]);

            if (x % y == 0 || y % x == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else { Console.WriteLine("Nao sao Multiplos"); }

        }
    }
}
