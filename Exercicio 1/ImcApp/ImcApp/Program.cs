using System;
using System.Collections.Generic;

namespace ImcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string RESP;
            List<Pessoa> nomes = new List<Pessoa>();


            Console.WriteLine("** Calculadora IMC **");
            Console.WriteLine("\n** INFORME OS DADOS DE 3 PESSOAS PARA ANALISE **");

            for (int i=0; i < 3; i++)
            {
                Console.WriteLine($"** PESSOA {i} - INFORME NOME **");
                string nome = Console.ReadLine();
                Console.WriteLine($"** PESSOA {i} - INFORME PESO EM KG **");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"** PESSOA {i} - INFORME ALTURA EM METROS ( EX: 1,70 )**");
                double altura = Convert.ToDouble(Console.ReadLine());

                Pessoa Pessoa = new Pessoa(nome, peso, altura);
                nomes.Add(Pessoa);

            }

            /*
            Pessoa Pessoa1 = new Pessoa("Bruno",70, 1.72);
            Pessoa Pessoa2 = new Pessoa("Aline",72, 1.62);
            Pessoa Pessoa3 = new Pessoa("Maria",80, 1.82);
             */

            Calculadora Cal = new Calculadora();

            for (int i = 0; i < 3; i++)
            {
                RESP = Cal.Calc_Imc(nomes[i]);
                Console.WriteLine($" {nomes[i].GetNome()} Fez sua avaliação e seu resultado foi : {RESP} ");
            }

        }
    }
}
