using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBForm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = @"Server=localhost;Database=mescontacts;Uid=root;Pwd=;";
            string requete = "update contacts set nom=@nom,telephone=@telephone,email=@email where id=@id";
            MySqlCommand cmd = new MySqlCommand(requete);
            cmd.Parameters.AddWithValue("@nom", txtNom.Text);
            cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = cn;
            try
            {
                cn.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("MIT A JOUR EXECUTEE AVEC SUCCES");
                else
                    MessageBox.Show("Aucune donnée n'a été mise à jour !");
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
