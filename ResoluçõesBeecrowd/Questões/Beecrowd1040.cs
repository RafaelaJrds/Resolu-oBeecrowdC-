using System;
using System.Globalization;

namespace ResoluçõesBeecrowd.Questões
{
    // URI 1040 Média 3
    public class Beecrowd1040
    {
        static void Main(string[] args)
        {
            string[] Valores = Console.ReadLine().Split(' ');
            double N1 = double.Parse(Valores[0], CultureInfo.InvariantCulture),
                N2 = double.Parse(Valores[1], CultureInfo.InvariantCulture),
                N3 = double.Parse(Valores[2], CultureInfo.InvariantCulture),
                N4 = double.Parse(Valores[3], CultureInfo.InvariantCulture);
            double media = Math.Round((N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / (2 + 3 + 4 + 1), 1);
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0) 
            { 
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media < 7.0 && media >= 5.0)
            {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double mediaExame = Math.Round(((exame + media) / 2), 1);
                if (mediaExame >= 5.0)
                {
                    Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                

            }
            


        }
    }
}
