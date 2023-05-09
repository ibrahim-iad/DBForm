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
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;Database=mescontacts;Trusted_Connection=True;";
            SqlCommand cmd = new SqlCommand("SELECT * FROM contacts;");
            cmd.Connection = cn;
            SqlDataReader mdr;
            try
            {
                cn.Open();
                mdr = cmd.ExecuteReader();
                while(mdr.Read())
                {
                    //MessageBox.Show("Nom: " + mdr["nom"] + " , Téléphone: " + mdr["phone1"]);
                    txtNom.Text = mdr["nom"].ToString();
                    txtTelephone.Text = mdr["telephone"].ToString();
                    txtEmail.Text = mdr["email"].ToString();
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
