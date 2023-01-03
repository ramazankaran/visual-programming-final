using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        public MySqlConnection MyConn = new MySqlConnection("Server=localhost;Database=spordb;Uid=root;Pwd='';");
        private void uyeler()
            
        {
            MyConn.Open();
            string query = "select * from uyetbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, MyConn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UyeDGV.DataSource = ds.Tables[0];
            MyConn.Close();

        }

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;

        private void UyeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(UyeDGV.SelectedRows[0].Cells[0].Value.ToString());
            AdSoyadTb.Text = UyeDGV.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = UyeDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox1.Text = UyeDGV.SelectedRows[0].Cells[3].Value.ToString();
            YasTb.Text = UyeDGV.SelectedRows[0].Cells[4].Value.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            textBox1.Text = "";
            YasTb.Text = "";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyConn.Open();
            MySqlCommand cmd = new MySqlCommand();
            //cmd.CommandText = "update uyetbl set UAdSoyad='" + AdSoyadTb.Text + "', UTelefon='" + TelefonTb.Text + "',Ucinsiyet='" + textBox1.Text + "',UYas='" + YasTb.Text + "' where UAdSoyad'"+AdSoyadTb.Text+"'";
            //MyConn.Close();
            string sql = "UPDATE uyetbl " +
                "SET UAdSoyad=@UAdSoyad,UTelefon=@UTelefon,UCinsiyet=@UCinsiyet,UYas=@UYas  WHERE UAdSoyad='"+AdSoyadTb.Text+"'";
            cmd = new MySqlCommand(sql, MyConn);
            cmd.Parameters.AddWithValue("@UAdSoyad",AdSoyadTb.Text);
            cmd.Parameters.AddWithValue("@UTelefon", TelefonTb.Text);
            cmd.Parameters.AddWithValue("UCinsiyet", textBox1.Text);
            cmd.Parameters.AddWithValue("@UYas", YasTb.Text);
            MyConn.Open();
            cmd.ExecuteNonQuery();
            MyConn.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
