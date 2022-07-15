using System;


namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //009 - Salário com Bônus
    public class Beecrowd1009
    {
        static void Main(string[] args)
        {
            string nomeDoVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendasDoMes = double.Parse(Console.ReadLine());

            double comissao = vendasDoMes * 0.15;

            double salarioComComissao = (salarioFixo + comissao);

            Console.WriteLine("TOTAL = R$ {0:0.00}", salarioComComissao);


            Console.ReadKey();
        }
    }
}
