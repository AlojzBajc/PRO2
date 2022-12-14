using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class kupec
    {
        protected string ime;
        protected decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; }
        //Ne moreš spreminjat   
        public void BeležiPlačilo(decimal plačilo)

        {
            stanje -= plačilo;
        }

        public virtual void BeležiKlic(int min, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;

                    break;

                case TipKlica.Mobilno:
                    stanje += min * 0.3m;

                    break;

                default:
                    break;

            }
        }

        public override string ToString()
        {
            return ime + "dolguje" + stanje + " evrov";
        }

    }

}
