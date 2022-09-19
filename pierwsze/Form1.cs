using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pierwsze
{
    public partial class Form1 : Form
    {
        private int licznik = 0;
        private int czas = 0;
        private int a ;
       private  int c ;
        private int d ;
        private int best_time=0 ;

        public Form1()
        {
            InitializeComponent();

        }

        private void ez_Click(object sender, EventArgs e)
        {
            
            licznik++;
            c = licznik + d;
            label1.Text ="Wynik: "+ c.ToString();
        }

        private void x(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
          a++;
            d = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = 0;
            licznik = 0;
            czas = 0;
            timer1.Start();

            timer2.Start();
            label2.Text = "Czas: " + czas.ToString() + 's';
            ez.Enabled = true;
            button1.Enabled = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ez.Enabled = false;

            if (best_time < c)
            {
                best_time = c;
                besttime.Text="Najlepszy wynik: "+c.ToString(); 
            }
            button1.Enabled = true;
            
            timer2.Stop();
            timer1.Stop();
            czas++;
            label2.Text = "Czas: " + czas.ToString() + 's';
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            czas++;
            label2.Text = "Czas: "+czas.ToString() + 's';
        }
    }
}
