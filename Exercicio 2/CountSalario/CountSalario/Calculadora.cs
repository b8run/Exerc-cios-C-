using System;
using System.Collections.Generic;
using System.Text;

namespace CountSalario
{
    class Calculadora
    {

        public double Count_Sal_MIN(Funcionario funcionario)
        {
            double renda = funcionario.GetSalario();
            //SALARIO MINIMO 1100
            return renda / 1100;
        }


    }
}
