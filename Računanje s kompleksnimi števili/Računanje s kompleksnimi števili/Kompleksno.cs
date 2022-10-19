using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje_s_kompleksnimi_števili
{
    internal class Kompleksno
    {
        double re;
        double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public Kompleksno(double r, double i)
        {
            re = r;im = i;
        }
        //koda za +,-,*
    }
}
