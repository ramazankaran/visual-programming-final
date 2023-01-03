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
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp5
{
    public partial class UyeEkle : Form
    {

        Baglanti asd = new Baglanti();

        public UyeEkle()
        {
            InitializeComponent();
        }
        

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (AdSoyadTb.Text != "" || TelefonTb.Text != "" || YasTb.Text != ""|| CinsiyetCb.Text !="" )
            {
                asd.uyeekle(AdSoyadTb.Text, TelefonTb.Text, YasTb.Text, CinsiyetCb.Text);
                MessageBox.Show("üye eklendi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            OdemeTb.Text = "";
            YasTb.Text = "";
            CinsiyetCb.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           AnaSayfa anasayfa=new AnaSayfa();
            anasayfa.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
