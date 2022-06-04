using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "Server=localhost;Database=contacts;Uid=root;Pwd=;";
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM contact;");
            cmd.Connection = cn;
            MySqlDataReader mdr;
            try
            {
                cn.Open();
                mdr = cmd.ExecuteReader();
                while(mdr.Read())
                {
                    //MessageBox.Show("Nom: " + mdr["nom"] + " , Téléphone: " + mdr["phone1"]);
                    txtNom.Text = mdr["nom"].ToString();
                    txtTelephone.Text = mdr["phone1"].ToString();
                    MessageBox.Show("SUIVANT");
                }
                mdr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
