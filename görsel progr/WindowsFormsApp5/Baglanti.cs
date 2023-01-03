using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    internal class Baglanti
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=spordb;Uid=root;Pwd='';");
        //public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=spordb;Uid=root;Pwd='';");


        public void uyeekle(string adsoyad, string telefon, string yas, string cinsiyet)
        {
            mysqlbaglan.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO uyetbl(UAdSoyad,UTelefon,UYas,UCinsiyet) VALUES('" + adsoyad + "','" +telefon+ "','"+yas+"','"+cinsiyet+ "')", mysqlbaglan);
            ekle.ExecuteNonQuery();
            mysqlbaglan.Close();
        }

       
        }
    }

