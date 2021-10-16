using System;
using System.Collections.Generic;
using System.Text;

namespace MediaEscolar
{
    class Aluno
    {
        private string nome;
        private int matricula;
        private double nota1;
        private double nota2;
        private double nota3;
        private double notaFinal;

        public Aluno(){

        }
        public Aluno(string nome, int mat, double nota1, double nota2, double nota3,double Final){

            SetMatricula(mat);
            SetNome(nome);
            SetNota1(nota1);
            SetNota2(nota2);
            SetNota3(nota3);
            SetNotaFinal(Final);
        }

        public string GetNome() => this.nome;
        public int GetMatricula() => this.matricula;
        public double GetNota1() => this.nota1;
        public double GetNota2() => this.nota2;
        public double GetNota3() => this.nota3;
        public double GetNotaFinal() => this.notaFinal;
        public void SetNome(string name) => this.nome = name;
        public void SetMatricula(int Matricula) => this.matricula = Matricula;
        public void SetNota1(double nota) => this.nota1 = nota;
        public void SetNota2(double nota) => this.nota2 = nota;
        public void SetNota3(double nota) => this.nota3 = nota;
        public void SetNotaFinal(double nota) => this.notaFinal = nota;


    }
}
