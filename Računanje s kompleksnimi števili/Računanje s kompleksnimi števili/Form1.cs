using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Računanje_s_kompleksnimi_števili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double re1 = 1; //pobere vsebino texta
            double im1 = 2;
            Kompleksno a = new Kompleksno(re1, im1);
            Kompleksno b = new Kompleksno(re2, im2);
            Kompleksno c = a + b;
            //Izpiši v label spodaj
            //labRezultat.Text = (a + b).ToString();

        }
    }
}
