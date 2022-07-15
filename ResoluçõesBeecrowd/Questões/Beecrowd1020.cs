using System;


namespace ResoluçõesBeecrowd.Questões
{
    //1020 Idade em dias
    public class Beecrowd1020
    {
        static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int anos = (idadeEmDias / 365);
            int meses = (int)((idadeEmDias - (anos * 365)) / 30);
            int dias = (int)((idadeEmDias - (anos * 365)) - (meses * 30));

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadKey();

        }
    }
}
