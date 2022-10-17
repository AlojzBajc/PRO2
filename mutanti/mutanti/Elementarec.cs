using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    internal class Elementarec : Mutant
    {
        int področje;

        public int Področje { get => področje; set => področje = value; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * Področje;
        }
    }
}
