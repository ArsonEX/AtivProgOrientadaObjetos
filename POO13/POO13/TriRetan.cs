﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO13
{
    class TriRetan
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

        public int trianguloRetangular()
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                return 1;
            }
            else
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                {
                    return 1;
                }
                else
                {
                    if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
