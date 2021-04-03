using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace projeSon
{
    public partial class Tetkik1 : Form
    {
        public Tetkik1()
        {
            InitializeComponent();
        }

        

        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from tetkik", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        

        private void Button3_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into tetkik (HastaAdı,tahlil) values ('" + textBox1.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("RANDEVU BAŞARIYLA ALINDI!");
            Listele();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
