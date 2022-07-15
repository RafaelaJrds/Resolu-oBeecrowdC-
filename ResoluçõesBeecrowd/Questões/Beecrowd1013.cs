using System;


namespace ResoluçõesBeecrowd.Questões.Iniciantes
{
    //1013 O Maior
    public class Beecrowd1013
    {
        static void Main(string[] args)
        {
            string[] Maior = Console.ReadLine().Split(' ');
            int A = int.Parse(Maior[0]), B = int.Parse(Maior[1]), C = int.Parse(Maior[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");

            Console.ReadKey();
        }
    }
}
