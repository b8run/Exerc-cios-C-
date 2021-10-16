using System;
using System.Collections.Generic;
using System.Text;

namespace ImcApp
{
    class Pessoa
    {
        protected string nome;
        protected double peso;
        protected double altura;

        public Pessoa()
        {

        }
        public Pessoa(string nome,double peso,double altura)
        {
            SetNome(nome);
            SetAltura(altura);
            SetPeso(peso);
        }

        public double GetPeso() => this.peso;

        public double GetAltura() => this.altura;

        public string GetNome() => this.nome;

        public void SetNome(string name) => this.nome = name;

        public void SetPeso(double peso) => this.peso = peso;

        public void SetAltura(double altura) => this.altura = altura;

    }
}
