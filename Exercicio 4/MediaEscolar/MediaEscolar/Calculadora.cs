using System;
using System.Collections.Generic;
using System.Text;

namespace MediaEscolar
{
    class Calculadora
    {
        public string SituaçãoNotaAluno(Aluno aluno)
        {
            double validação = aluno.GetNota1() + aluno.GetNota2() + aluno.GetNota3();

            if ((validação/3) >= 7)
            {
                return $"APROVADO  --  MÉDIA { validação/3 }";
            }
            else
            {
                double Final = validação + aluno.GetNotaFinal();

                if((Final/4) >= 5)
                {
                    return $"APROVADO EM EXAME  --  MÉDIA { Final/4 }";
                }
                else
                {
                    return $"REPROVADO  --  MÉDIA { Final/4 }";
                }
            }
        }
    }
}
