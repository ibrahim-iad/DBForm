using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBForm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = @"Server=localhost;Database=mescontacts;Uid=root;Pwd=;";
            string requete = "delete from contacts where id=@id";
            MySqlCommand cmd = new MySqlCommand(requete);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Connection = cn;
            try
            {
                cn.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("SUPPRESSION EXECUTEE AVEC SUCCES");
                else
                    MessageBox.Show("Aucune donnée n'a été supprimée !");
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
