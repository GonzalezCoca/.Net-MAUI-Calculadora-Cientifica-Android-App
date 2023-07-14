using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;

namespace Calculadora
{
    public static class Calculate
    {
        public static double HazCalculo(double valor1,double valor2,string operadorMath)
        {
            double resultado = 0;

            switch(operadorMath)
            {
                case "/":
                    resultado = valor1/valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "x^n":
                    resultado = Math.Pow(valor1,valor2);
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}
