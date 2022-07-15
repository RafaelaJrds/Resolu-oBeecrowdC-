using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1010 Cálculo Simples
    public class Beecrowd1010
    {
        static void Main(string[] args)
        {
            string[] Peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(Peca1[0]), numeroDePecas1 = int.Parse(Peca1[1]);
            double valorUnidadeP1 = double.Parse(Peca1[2]);

            string[] Peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(Peca2[0]), numeroDePecas2 = int.Parse(Peca2[1]);
            double valorUnidadeP2 = double.Parse(Peca2[2]);

            double totalP1P2 = (numeroDePecas1 * valorUnidadeP1) + (numeroDePecas2 * valorUnidadeP2);

            Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", totalP1P2);

            Console.ReadKey();
        }
    }
}
