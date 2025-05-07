using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int longeur = int.Parse(txtLongueur.Text);
            int largeur = int.Parse(txtLargeur.Text);
            int perimetre = 2 * (longeur + largeur);
            int surface = longeur * largeur;
            txtPerimetre.Text = perimetre.ToString();
            txtSurface.Text = surface.ToString();

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = @"Server=localhost;Database=mescontacts;Uid=root;Pwd=;";
            string requete = "insert into rectangle(longueur,largeur,perimetre,surface) values(@longueur,@largeur,@perimetre,@surface)";
            MySqlCommand cmd = new MySqlCommand(requete);
            cmd.Parameters.AddWithValue("@longueur", longeur.ToString());
            cmd.Parameters.AddWithValue("@largeur", largeur.ToString());
            cmd.Parameters.AddWithValue("@perimetre", perimetre.ToString());
            cmd.Parameters.AddWithValue("@surface", surface.ToString());
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
