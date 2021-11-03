using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO9
{
    class MaiorIgual
    {
        int n1;
        int n2;
        public void setn1(int x)
        {
            n1 = x;
        }

        public void setn2(int x)
        {
            n2 = x;
        }

        public int getn1()
        {
            return n1;
        }

        public int getn2()
        {
            return n2;
        }

        public int indicarMaior()
        {
            if (n1==n2)
            {
                return 0;
            }
            else
            {
                if (n1>n2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
