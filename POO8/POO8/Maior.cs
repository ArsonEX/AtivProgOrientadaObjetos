using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO8
{
    class Maior
    {
        int n1;
        int n2;
        string ns="'não atribuido'";

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
        public string getns()
        {
            return ns;
        }

        public int indicarMaior()
        {
            if(n1>n2)
            {
                ns = "primeiro";
                return n1;
            }
            else
            {
                ns = "segundo";
                return n2;     
            }
        }
    }
}
