using System;


namespace ResoluçõesBeecrowd.Questões
{
    //1019 Conversão de tempo
    public class Beecrowd1019
    {
        static void Main(string[] args)
        {
            int tempoSegundos = int.Parse(Console.ReadLine());

            int hora = (tempoSegundos / 3600);
            int minutos = (int)((tempoSegundos - (hora * 3600)) / 60);
            int segundos = (int)((tempoSegundos - (hora * 3600)) - (minutos * 60));

            Console.WriteLine(hora + ":" + minutos + ":" + segundos);

            Console.ReadKey();
        }
    }
}
