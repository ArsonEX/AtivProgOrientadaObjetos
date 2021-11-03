using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO1
{
    class Area
    {
        private int basinha;
        private int altura;
        private int resultado;

        #region getset
        public void setBasinha(int x)
        {
            basinha = x;
        }

        public void setAltura(int x)
        {
            altura = x; ;
        }

        public int getBasinha()
        {
            return basinha;
        }

        public int getAltura()
        {
            return altura;
        }

        public int getResultado()
        {
            return resultado;
        }
        #endregion

        public void calcular()
        {
            resultado = basinha * altura;
        }
    }
}
