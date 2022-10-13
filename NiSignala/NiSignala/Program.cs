﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kupec janez = new kupec();
            janez.Ime = ("Janez Novak");
            janez.BeležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(janez.Ime + " dolguje " + janez.Stanje);
            Console.WriteLine("get type "+janez.GetType());
            Console.WriteLine("to string " + janez.ToString());

            kupec alenka = new Kupec60();
            alenka.Ime = ("Alenka Novak");
            alenka.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);
            Console.WriteLine("get type " + alenka.GetType());
            Console.WriteLine("to string " + alenka.ToString());

            Console.ReadLine();


        }
    }
}
