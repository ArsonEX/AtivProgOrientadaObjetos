using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO12
{
    class FTriangulo
    {
        int a;
        int b;
        int c;

        public void setA(int x)
        {
            a = x;
        }

        public void setB(int x)
        {
            b = x;
        }

        public void setC(int x)
        {
            c = x;
        }

        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }

        public int getC()
        {
            return c;
        }

        public string triangular()
        {
            if (a + b < c)
            {
                return "Não";
            }
            if (a + c < b)
            {
                return "Não";
            }
            if (b + c < a)
            {
                return "Não";
            }

            //tipo de triangulo
            if (a == b && a == c) //equilátero
            {
                return "equilátero";
            }
            if (a == b || b == c || a == c) //isosceles
            {
                return "isosceles";
            }
            else //escaleno
            {
                return "escaleno";
            }
        }
    }
}
