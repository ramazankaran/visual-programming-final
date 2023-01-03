using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=spordb;Uid=root;Pwd='';");
        
         private void uyeler()
        {
            mysqlbaglan.Open();
            string query = "select * from uyetbl";
            MySqlDataAdapter sda = new MySqlDataAdapter (query,mysqlbaglan);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            mysqlbaglan.Close();
        }

      

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            uyeler();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();

        }
        
     

        private void button2_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            string query = "select * from OdemeTbl where OUye='" + AraUyeTb.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, mysqlbaglan);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            mysqlbaglan.Close();
        }

        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AraUyeTb_TextChanged(object sender, EventArgs e)
        {
            string aranan = AraUyeTb.Text.Trim().ToUpper();
            for (int i = 0; i <= UyeDGV.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in UyeDGV.Rows)
                {
                    foreach (DataGridViewCell cell in UyeDGV.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
