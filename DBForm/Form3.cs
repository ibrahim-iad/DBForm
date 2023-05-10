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

namespace DBForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;Database=mescontacts;Trusted_Connection=True;";
            string requete = "insert into contacts (nom,telephone,email) values(@nom,@telephone,@email)";
            SqlCommand cmd = new SqlCommand(requete);
            cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Connection = cn;
            try
            {
                cn.Open();
                int res = cmd.ExecuteNonQuery();
                MessageBox.Show("REQUETE EXECUTEE AVEC SUCCES");
            }
            catch (Exception ex)
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
