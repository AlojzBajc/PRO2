using System;
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

            kupec alenka = new kupec();
            alenka.Ime = ("Alenka Novak");
            alenka.BeležiKlic(10, TipKlica.Mobilno);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);

            Console.ReadLine();


        }
    }
}
