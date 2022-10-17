﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutanti
{
    internal abstract class Mutant : IPrikazovalnik
    {
        private string ime;
        private int stopnja;

        public string Ime { get => ime; set => ime = value; }
        public int Stopnja { get => stopnja; set => stopnja = value; }

        public void PrikažiInformacije()
        {
            Console.WriteLine("Mutant"+ime+" ima kvocient nevarnosti "+KvocientNevarnosti());
        }
        public abstract int KvocientNevarnosti();


    }
}
