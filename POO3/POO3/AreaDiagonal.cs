using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class AreaDiagonal
    {
        double diagonal;
        double resultado;

        public void setDiagonal(double x)
        {
            diagonal = x;
        }

        public double getDiagonal()
        {
            return diagonal;
        }

        public double getResultado()
        {
            return resultado;
        }

        public void calcular()
        {
            resultado = (Math.Pow(diagonal, 2)) / 2;
        }
    }
}
