using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class AreaQuadrado
    {
        private double aresta;
        private double resultado;

        public void setAresta(double x)
        {
            aresta = x;
        }

        public double getAresta()
        {
            return aresta;
        }

        public double getResultado()
        {
            return resultado;
        }

        public void calcular()
        {
            resultado = Math.Pow(aresta, 2);
        }
    }
}
