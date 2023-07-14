using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;

namespace Calculadora
{
    class Calc
    {
        public Calc() { }
        double sol;
        public double Fun(double x,string fx)
        {
            sol = MathParse.Parse(fx).Evaluate(x);
            return sol;
        }
    }
}
