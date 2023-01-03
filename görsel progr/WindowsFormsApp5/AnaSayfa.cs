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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle=new UyeEkle();
            uyeekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelle=new GuncelleSil();
            guncelle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odeme odeme=new Odeme();
            odeme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeleriGoruntule uyelerigoruntule = new UyeleriGoruntule();

            uyelerigoruntule.Show();
            this.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İletisim iletisim = new İletisim();
            iletisim.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vizyon vizyon  = new Vizyon();
            vizyon.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Misyon misyon = new Misyon();
            misyon.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            frmmain.Show();
            this.Hide();
        }
    }
}
