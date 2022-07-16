using System;
using System.Collections.Generic;

namespace ResoluçõesBeecrowd.Questões
{
    // 1042 Sort Simples
    public class Beecrowd1042
    {
        public void Main(string [] args)
        {
            int x, y, z;
            string[] Valores;
            Valores = Console.ReadLine().Split(' ');
            x = int.Parse(Valores[0]);
            y = int.Parse(Valores[1]);
            z = int.Parse(Valores[2]);
            List<int> lista = new List<int>();
            lista.Add(x);
            lista.Add(y);
            lista.Add(z);

            lista.Sort();

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
