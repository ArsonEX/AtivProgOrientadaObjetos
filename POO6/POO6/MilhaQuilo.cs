using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO6
{
    class MilhaQuilo
    {
        double milhas;
        double resultado;

        public void setMilhas(double x)
        {
            milhas = x;
        }

        public double getMilhas()
        {
            return milhas;
        }

        public double getResultado()
        {
            return resultado;
        }

        public void calcular()
        {
            resultado = milhas * 1.852;
        }
    }
}
