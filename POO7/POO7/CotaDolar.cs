using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO7
{
    class CotaDolar
    {
        double cotacao;
        double quantia;
        double resultado;

        public void setCotacao(double x)
        {
            cotacao = x;
        }

        public void setQuantia(double x)
        {
            quantia = x;
        }

        public double getCotacao()
        {
            return cotacao;
        }

        public double getQuantia()
        {
            return quantia;
        }

        public double getResultado()
        {
            return resultado;
        }

        public void calcular()
        {
            resultado = quantia * cotacao;
        }
    }
}
