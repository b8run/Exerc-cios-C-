using System;
using System.Collections.Generic;

namespace GeometriaEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GeoEsfera> Esferas = new List<GeoEsfera>();
            double RESP;

            Console.WriteLine("\n** INFORME QUANTAS ESFERAS DESEJA ANALISAR **");

            int NUM_ESF = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("** Calculo de RAIO **");
            Console.WriteLine($"\n** INFORME OS DADOS DE RADIO DE {NUM_ESF} ESFERAS PARA ANALISE **");

            for (int i = 0; i < NUM_ESF; i++)
            {
                Console.WriteLine($"** Esfera {i+1} :**");
                double Raio = Convert.ToDouble( Console.ReadLine());
      
                GeoEsfera ESF = new GeoEsfera(Raio);
                Esferas.Add(ESF);
            }

            for (int i = 0; i < NUM_ESF; i++){

                RESP = Esferas[i].Vol_Esfera();
                Console.WriteLine($"O Raio da Esfera {i+1} é => {Math.Round(RESP, 2)}");
            }
        }
    }
}
