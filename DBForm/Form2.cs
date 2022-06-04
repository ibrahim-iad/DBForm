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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "Server=localhost;Database=contacts;Uid=root;Pwd=;";
            string requete = "insert into contact (nom,phone1,id_user) values('" + txtNom.Text + 
                "','" + txtTelephone.Text + "',1)";
            MySqlCommand cmd = new MySqlCommand(requete);
            cmd.Connection = cn;
            //MySqlDataReader mdr;
            try
            {
                cn.Open();
                int res = cmd.ExecuteNonQuery();
                MessageBox.Show("REQUETE EXECUTEE");
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
