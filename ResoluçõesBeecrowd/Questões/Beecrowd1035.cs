using System;


namespace ResoluçõesBeecrowd.Questões
{
    //1035 Teste de Seleção 1
    public class Beecrowd1035
    {
        static void Main(string[] args)
        {

            string[] Valores = Console.ReadLine().Split(' ');
            int A = int.Parse(Valores[0]),
                B = int.Parse(Valores[1]),
                C = int.Parse(Valores[2]),
                D = int.Parse(Valores[3]);
            if ((B > C) && (D > A) && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else { Console.WriteLine("Valores nao aceitos"); }

        }
    }
}
