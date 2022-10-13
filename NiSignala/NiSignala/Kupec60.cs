using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Kupec60:kupec
    {
        private int višjaTarifaPorabljeno;
        public override void BeležiKlic(int min, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;

                    break;

                case TipKlica.Mobilno:
                    stanje += min * 0.2m;
                    int vMinute, nMinute;
                    int šeVMinute = (višjaTarifaPorabljeno < 60) ?
                        60 - višjaTarifaPorabljeno : 0;
                    if (min > šeVMinute) //en klic dve tarifi
                    {
                        vMinute = šeVMinute;
                        nMinute = min - vMinute;
                    }
                    else 
                    {
                        vMinute = min;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.35m + nMinute * 0.01m;
                    višjaTarifaPorabljeno += vMinute;
                    break;

                default:
                    break;

            }
        }
    }
}
