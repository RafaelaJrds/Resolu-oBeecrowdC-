using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões
{
    //1038 Lanche (Resolução usando switch)
    public class Beecrowd1038sw
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');
            int codigoProduto = int.Parse(dados[0]),
                quantidadeProduto = int.Parse(dados[1]);

            double total;
            switch (codigoProduto)
            {
                case 1:
                    total = quantidadeProduto * 4.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = quantidadeProduto * 4.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = quantidadeProduto * 5.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = quantidadeProduto * 2.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = quantidadeProduto * 1.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default: total = 0; break;

            }

        }
    }
}
