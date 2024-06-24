
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class login : Form


    {

        private String connstring = "Database=ejemplo;Server=localhost;User ID=root;Password=";

        public string usuario { get { return txtusuario.Text; } }
        public string clave { get { return txtclave.Text; } }

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string clave = txtclave.Text;

            if (VerificarCredenciales(usuario, clave))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo nuevamente.");
            }


        }
        public bool VerificarCredenciales(string usuario, string clave)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE cod_usu = @25 AND nom_usu = @rosa";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cod_usu", 25);
                    cmd.Parameters.AddWithValue("@nom_usu", "rosa");

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}

