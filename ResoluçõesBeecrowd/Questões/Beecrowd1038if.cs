using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões
{
    //1038 Lanche (REsolução usando if)
    public class Beecrowd1038if
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');
            int codigoProduto = int.Parse(dados[0]),
                quantidadeProduto = int.Parse(dados[1]);

            if ((codigoProduto == 1))
            {
                var total = quantidadeProduto * 4.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }

            else if ((codigoProduto == 2))
            {
                var total = quantidadeProduto * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if ((codigoProduto == 3))
            {
                var total = quantidadeProduto * 5.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if ((codigoProduto == 4))
            {
                var total = quantidadeProduto * 2.00;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if ((codigoProduto == 5))
            {
                var total = quantidadeProduto * 1.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}


