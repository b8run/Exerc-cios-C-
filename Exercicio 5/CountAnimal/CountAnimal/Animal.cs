using System;
using System.Collections.Generic;
using System.Text;

namespace CountAnimal
{
    public abstract class Animal
    {
        private string nome;
        private int num_patas;
        private double peso;
        private string Porte_Animal;
        private string tipoAnimal;

        public string GetNome() => this.nome;
        public int GetNum_Patas() => this.num_patas;
        public double GetPeso() => this.peso;
        public string GetPorteAnimal() => this.Porte_Animal;
        public string GetTipoAnimal() => this.tipoAnimal;
        public void SetNome(string nome) => this.nome = nome;
        public void SetNumPatas(int n_patas) => this.num_patas = n_patas;
        public void SetPeso(double Peso) => this.peso = Peso;
        public void SetPorteAnimal(string porte) => this.Porte_Animal = porte;
        public void SetTipoAnimal(string tipo) => this.tipoAnimal = tipo;
        
        public abstract string SOM();
    


    }
}
