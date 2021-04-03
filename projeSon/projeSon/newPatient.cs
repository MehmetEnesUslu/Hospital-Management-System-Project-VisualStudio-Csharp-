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
    public partial class newPatient : Form
    {
        public newPatient()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Hasta (adı,soyadı,kurum) values ('" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("HASTA BİLGİLERİ BAŞARIYLA KAYIT EDİLDİ!");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into ServisHasta (HastaKodu,Servis,Oda,Doktor,Giris,Cikis,Fiyat) values ('" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + dateTimePicker2.Text.ToString() + "','" + textBox8.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YATIŞ BİLGİLERİ BAŞARIYLA KAYIT EDİLDİ!");
            this.Hide();
        }
    }
}
