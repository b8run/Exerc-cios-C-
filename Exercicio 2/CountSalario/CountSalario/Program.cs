using System;
using System.Collections.Generic;
namespace CountSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> nomes = new List<Funcionario>();
            double RESP;

            Console.WriteLine("\n** INFORME QUANTOS FUNCIONARIOS DESEJA ANALISAR **");

            int CONT_FUNC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("** Calcular Salario **");
            Console.WriteLine($"\n** INFORME OS DADOS DE {CONT_FUNC} PESSOAS PARA ANALISE **");

            for (int i = 0; i < CONT_FUNC; i++)
            {
                Console.WriteLine($"** PESSOA {i} - INFORME NOME**");
                string nome = Console.ReadLine();
                Console.WriteLine($"** PESSOA {i} - INFORME O SALARIO**");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"** PESSOA {i} - INFORME CARGO**");
                string cargo = Console.ReadLine();

                Funcionario Pessoa = new Funcionario(nome, salario, cargo);
                nomes.Add(Pessoa);
            }

            Calculadora Calc = new Calculadora();

            for (int i = 0; i < CONT_FUNC; i++)
            {
                RESP = Calc.Count_Sal_MIN(nomes[i]);
                Console.WriteLine($" {nomes[i].GetNome()} Realizou o calculo de Salario, Sua renda é : {Math.Round(RESP,2)} vezes o Salario Minimo ATUAL ");

            }
        }
    }
}
