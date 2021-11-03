using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    class AreaTriangulo
    {
        double basin;
        double altura;
        double resultado;

        #region setget
        public void setBasin(double x)
        {
            basin = x;
        }

        public void setAltura(double x)
        {
            altura = x;
        }

        public double getBasin()
        {
            return basin;
        }

        public double getAltura()
        {
            return altura;
        }

        public double getResultado()
        {
            return resultado;
        }
        #endregion

        public void calcular()
        {
            resultado = (basin * altura) / 2;
        }
    }
}
