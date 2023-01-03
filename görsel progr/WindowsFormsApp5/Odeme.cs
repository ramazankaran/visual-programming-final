using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        public MySqlConnection MyConn = new MySqlConnection("Server=localhost;Database=spordb;Uid=root;Pwd='';");
        private void FillName()
        {
            MyConn.Open();
            MySqlCommand cmd = new MySqlCommand("select OUye from odemetbl", MyConn);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("OUye", typeof(string));
            dt.Load(rdr);
            textBox1.Text = "Ad Soyad";
            textBox1.Text= dt.ToString();
            MyConn.Close();

        }
        private void Adfiltrele()
        {
            MyConn.Open();
            string query = "select * from OdemeTbl where OUye='"+AraTb.Text+"'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, MyConn);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDGV.DataSource = ds.Tables[0];
            MyConn.Close();
        }
        private void uyeler()
        {
            MyConn.Open();
            string query = "select * from OdemeTbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, MyConn);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDGV.DataSource = ds.Tables[0];
            MyConn.Close();
        }
        private void Odeme_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            OdemeTb.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == ""||OdemeTb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                string odemeperiyot = Periyot.Value.ToString() + Periyot.Value.Year.ToString();
                MyConn .Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from odemeTbl where AdSoyad='" + textBox1.Text.ToString() + "' and OAy='" + odemeperiyot + "'", MyConn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                
              
                
                    string query = "insert into OdemeTbl(AdSoyad,OMiktar) values('"+textBox1.Text.ToString()+"',"+OdemeTb.Text+")";
                    MySqlCommand komut = new MySqlCommand(query,MyConn);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Tutar Başarıyla Ödendi");
              
               MyConn.Close();
                uyeler();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adfiltrele();
            AraTb.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void OdemeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string MyConnection2 = "Server=localhost;Database=spordb;Uid=root;Pwd='';";
                //Display query
                string Query = "select * from student.studentinfo;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                OdemeDGV.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.                                
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdSoyadCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
