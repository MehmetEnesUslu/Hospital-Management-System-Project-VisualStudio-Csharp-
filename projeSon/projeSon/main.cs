using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeSon
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RandevuKayit1 rAl = new RandevuKayit1();

           // rAl.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Servis1 sF = new Servis1();

            //sF.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // Depo1 dF = new Depo1();

            //dF.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            newPatient HS = new newPatient();
            HS.Show();
        }



        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           // Poliklinik1 Po = new Poliklinik1();

           // Po.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Tetkik1 T = new Tetkik1();
           // T.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            RandevuKayit1 rAl = new RandevuKayit1();

            rAl.Show();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Servis1 sF = new Servis1();

            sF.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Tetkik1 T = new Tetkik1();
            T.Show();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Depo1 dF = new Depo1();

            dF.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Poliklinik1 Po = new Poliklinik1();

            Po.Show();
        }
    }
}
