using System;
using System.Collections.Generic;
using System.Text;

namespace ImcApp
{
    class Calculadora
    {
        public string Calc_Imc(Pessoa people)
        {
            double value_IMC =  people.GetPeso() / (people.GetAltura() * people.GetAltura());

            if (value_IMC < 20)
            {
                Console.WriteLine(people.GetPeso());
                Console.WriteLine(people.GetAltura());

                return "Abaixo do peso";
            }else if ((value_IMC <= 20) || (value_IMC < 25))
            {
                 return "Peso Ideal";
            }
            else if(value_IMC >= 25)
            {
                 return "Acima do Peso";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
