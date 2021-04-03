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
    public partial class RandevuKayit1 : Form
    {
        public RandevuKayit1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into randevu (RandevuNo,hastaAdı,doktorAdı,poliklinik,tarih) values ('" + textBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("RANDEVU BAŞARIYLA ALINDI!");
            Listele();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from randevu where RandevuNo= ('" + textBox4.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("RANDEVU İPTAL İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ!");
            Listele();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        DataTable tablo = new DataTable();


        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from randevu", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
