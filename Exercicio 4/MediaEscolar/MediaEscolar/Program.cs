using System;

namespace MediaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            // O ALUNO RECEBE COMO PADRÃO O NOME | MATRICULA | NOTA1 | NOTA2 | NOTA3 | NOTAFINAL

            Aluno BRUNO = new Aluno("Bruno",0001,10,5,1,4.5);
            Calculadora Calc = new Calculadora();

            string Sit_Aluno = Calc.SituaçãoNotaAluno(BRUNO);

            Console.WriteLine($" {BRUNO.GetNome()} Concluio suas provas e o resultado final foi : {Sit_Aluno}");



        }
    }
}
