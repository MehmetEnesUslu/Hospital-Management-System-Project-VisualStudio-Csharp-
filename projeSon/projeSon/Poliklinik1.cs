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
    public partial class Poliklinik1 : Form
    {
        public Poliklinik1()
        {
            InitializeComponent();
        }


       

       

        

        DataTable tablo = new DataTable();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");

        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Doktorlar", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Doktorlar (İsim,Bölüm) values ('" + textBox1.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ DOKTOR KAYDI BAŞARIYLA EKLENDİ!");
            Listele();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VeriTabani.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Doktorlar where İsim= ('" + textBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İSTEDİĞİNİZ DOKTOR SİSTEMDEN SİLİNMİŞTİR!");
            Listele();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
