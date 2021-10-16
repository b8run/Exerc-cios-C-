using System;
using System.Collections.Generic;
using System.Text;

namespace CountAnimal
{
    class Peixe : Animal
    {
        public Peixe(string nome, double peso, string porte_Animal,string tipo)
        {
            this.SetNome(nome);
            this.SetPeso(peso);
            this.SetPorteAnimal(porte_Animal);
            this.SetTipoAnimal(tipo);
        }
        public override string SOM()
        {
            return "........... ......... ...........";
        }
    }
}
