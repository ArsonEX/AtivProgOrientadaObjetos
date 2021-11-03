using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO11
{
    class IMC
    {
        double altura;
        double peso;
        double Imc;

        public void setAltura(double x)
        {
            altura = x;
        }

        public void setPeso(double x)
        {
            peso = x;
        }

        public double getAltura()
        {
            return altura;
        }

        public double getPeso()
        {
            return peso;
        }

        public double getImc()
        {
            return Imc;
        }

        public void calcular()
        {
            Imc = peso / Math.Pow(altura,2);
        }
    }
}
