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
    public partial class Depo1 : Form
    {
        public Depo1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Depo", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Depo (Urun,Miktar,Azami,Asgari,SonKullanma,Yer) values ('" + textBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dataPicker.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ İLAÇ BAŞARIYLA EKLENDİ!");
            Listele();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Depo where Urun= ('" + textBox5.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ!");
            Listele();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable tablo1 = new DataTable();
        private void Button1_Click(object sender, EventArgs e)
        {
            Listele1();
        }

        private void Listele1()
        {
            tablo1.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from DepoMalzemeler", baglanti);
            adtr.Fill(tablo1);
            dataGridView2.DataSource = tablo1;
            baglanti.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into DepoMalzemeler (Urun,Miktar,Yer) values ('" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ MALZEME BAŞARIYLA EKLENDİ!");
            Listele1();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from DepoMalzemeler where Urun= ('" + textBox8.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ!");
            Listele1();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Listele1();
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Depo (Urun,Miktar,Azami,Asgari,SonKullanma,Yer) values ('" + textBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dataPicker.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ İLAÇ BAŞARIYLA EKLENDİ!");
            Listele();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Depo where Urun= ('" + textBox5.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ!");
            Listele();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into DepoMalzemeler (Urun,Miktar,Yer) values ('" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ MALZEME BAŞARIYLA EKLENDİ!");
            Listele1();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from DepoMalzemeler where Urun= ('" + textBox8.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ!");
            Listele1();
        }
    }
}
