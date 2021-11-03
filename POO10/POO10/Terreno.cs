using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO10
{
    class Terreno
    {
        double basin;
        double altura;
        double area;

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

        public double getArea()
        {
            return area;
        }

        public void calcular()
        {
            area = basin * altura;
        }
    }
}
