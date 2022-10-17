using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    internal class Fizikalec : Mutant
    {
        int iq;
        int moč;

        public int IQ { get => iq; set => iq = value; }
        public int Moč { get => moč; set => moč = value; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * IQ * Moč;
        }
    }
}
