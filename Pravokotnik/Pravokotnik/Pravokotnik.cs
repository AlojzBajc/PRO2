using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{

    internal class Pravokotnik
    {
        private double ploščina;
        private double višina;
        private double širina;

        public double Ploščina { get => širina * višina; }
        public double Višina { get => višina; set => višina = value; }
        public double Širina { get => širina; set => širina = value; }

        public Pravokotnik()
        {
            Širina = 0;
            Višina = 0;
        }
        public Pravokotnik(double š, double v)
        {
            Širina = š;
            Višina = v;
        }

        public static bool operator ==(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina == p2.Ploščina;
        }

        public static bool operator >(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina > p2.Ploščina;
        }

        public static bool operator <(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina < p2.Ploščina;
        }

        public static bool operator >=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina >= p2.Ploščina;
        }
        public static bool operator <=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina <= p2.Ploščina;
        }
        public static bool operator !=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina != p2.Ploščina;
        }

        public override string ToString()
        {
            return " Višina=" + višina + " Širina=" + širina;
            
        }


    }

}
