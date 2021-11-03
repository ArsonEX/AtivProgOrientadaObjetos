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

        public void triangular()
        {
            if (a + b < c)
            {
                Console.Write("Não formam triângulo");
                return;
            }
            if (a + c < b)
            {
                Console.Write("Não formam triângulo");
                return;
            }
            if (b + c < a)
            {
                Console.Write("Não formam triângulo");
                return;
            }

            //tipo de triangulo
            if (a == b && a == c)
            {
                Console.Write("Triângulo equilátero");
                return;
            }
            if (a == b || b == c || a == c)
            {
                Console.Write("Triângulo isosceles");
            }
            else
            {
                Console.Write("Triângulo escaleno");
            }
        }
    }
}
