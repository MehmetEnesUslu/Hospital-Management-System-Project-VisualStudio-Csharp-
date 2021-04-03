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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text;

            if (pass == "11111")
            {
                // MessageBox.Show("Dogru parola.");
                this.Hide();
                main A = new main();
                A.Show();

            }


            else
                MessageBox.Show("Yanlis parola.");
        }
    }
}
