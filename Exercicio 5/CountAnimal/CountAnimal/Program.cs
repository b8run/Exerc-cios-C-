using System;
using System.Collections.Generic;

namespace CountAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> lista_Animais = new List<Animal>();
            int N_Gato = 0, N_Peixe = 0, N_Cachorro = 0;

            Console.WriteLine("\n** INFORME QUANTIDADE DE ANIMAIS**\n");

            int qtdd_animais = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("** Contagem de Animais **\n");
            Console.WriteLine($"** INFORME OS DADOS DOS {qtdd_animais} ANIMAIS **\n");

            for (int i = 0; i < qtdd_animais; i++)
            {
                int n_patas = 0;
                Console.WriteLine($"** ANIMAL {i+1} - INFORME TIPO DO ANIMAL **");
                string tipo = Console.ReadLine().ToUpper();
                if (tipo != "PEIXE") {
                    Console.WriteLine($"** ANIMAL {i+1} - INFORME NUMERO DE PATAS **");
                    n_patas = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"** ANIMAL {i+1} - INFORME NOME **");
                string nome = Console.ReadLine();
                Console.WriteLine($"** ANIMAL {i+1} - INFORME O PESO**");
                double peso = Convert.ToDouble( Console.ReadLine() ) ;
                Console.WriteLine($"** ANIMAL {i+1} - INFORME PORTE **");
                string porte = Console.ReadLine();
                

                switch (tipo)
                {
                    case "CACHORRO":
                        Cachorro dog = new Cachorro(nome,n_patas,peso,porte,tipo);
                        lista_Animais.Add(dog);
                        break;
                    case "GATO":
                        Gato cat = new Gato(nome, n_patas, peso, porte, tipo);
                        lista_Animais.Add(cat);
                        break;
                    case "PEIXE":
                        Peixe fish = new Peixe(nome, peso, porte, tipo);
                        lista_Animais.Add(fish);
                        break;
                    default:
                        Peixe DF = new Peixe(nome, peso, porte, tipo);
                        lista_Animais.Add(DF);
                        break;
                }

            }

            foreach (Animal animal in lista_Animais){

                if (animal.GetTipoAnimal() == "PEIXE")
                {
                    N_Peixe++;
                }else if (animal.GetTipoAnimal() == "CACHORRO")
                {
                    N_Cachorro++;
                }
                else
                {
                    N_Gato++;
                }
            }
            Console.WriteLine($"FOI PASSADO {qtdd_animais} animais");
            Console.WriteLine($"sendo { N_Gato } Gatos, { N_Peixe } Peixes e {N_Cachorro} Cahocorros");
        }
    }
}
