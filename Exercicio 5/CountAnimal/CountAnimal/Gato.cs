using System;
using System.Collections.Generic;
using System.Text;

namespace CountAnimal
{
    class Gato : Animal
    {

        public Gato(string nome,int n_Patas, double peso, string porte_Animal, string tipo)
        {
            this.SetNome(nome);
            this.SetNumPatas(n_Patas);
            this.SetPeso(peso);
            this.SetPorteAnimal(porte_Animal);
            this.SetTipoAnimal(tipo);
        }

        public override string SOM()
        {
            return " MIIAU .... MIAUUU ";
        }
    }
}
