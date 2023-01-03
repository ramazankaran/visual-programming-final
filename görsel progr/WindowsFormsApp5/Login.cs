using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Baglanti asd = new Baglanti();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicitb.Text = "";
            SifreTb.Text = "";

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            asd.mysqlbaglan.Open();
            MySqlCommand ekle = new MySqlCommand("select * from login where kadi='" + Kullanicitb.Text + "' and sifre='" + SifreTb.Text + "'", asd.mysqlbaglan);
            MySqlDataReader reader = ekle.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("giriş başarılı <3 BALIKESİR/DURSUNBEY <3");
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();

            }
            else
            {
                MessageBox.Show("hatali giris");
            }
            asd.mysqlbaglan.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
