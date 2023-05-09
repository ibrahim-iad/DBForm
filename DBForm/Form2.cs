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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;Database=mescontacts;Trusted_Connection=True;";
            string requete = "insert into contacts (nom,telephone,email) values('" + txtNom.Text + 
                "','" + txtTelephone.Text + "','" + txtEmail.Text + "')";
            SqlCommand cmd = new SqlCommand(requete);
            cmd.Connection = cn;
            //MySqlDataReader mdr;
            try
            {
                cn.Open();
                int res = cmd.ExecuteNonQuery();
                MessageBox.Show("REQUETE EXECUTEE AVEC SUCCES");
                /*while (mdr.Read())
                {
                    //MessageBox.Show("Nom: " + mdr["nom"] + " , Téléphone: " + mdr["phone1"]);
                    txtNom.Text = mdr["nom"].ToString();
                    txtTelephone.Text = mdr["phone1"].ToString();
                    MessageBox.Show("SUIVANT");
                }*/
                //mdr.Close();
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
