using System;
using System.Collections.Generic;
using System.Text;

namespace CountSalario
{
    class Funcionario
    {
        private string nome;
        private double salario;
        private string cargo;

        public Funcionario(string nome, double salario, string cargo)
        {
            SetNome(nome);
            SetSalario(salario);
            SetCargo(cargo);
     
        }
        public string GetNome() => this.nome;
        public double GetSalario() => this.salario;
        public string GetCargo() => this.cargo;
        public void SetNome(string value) => this.nome = value;
        public void SetSalario(double value) => this.salario = value;
        public void SetCargo(string value) => this.cargo = value;
       


    }





}
