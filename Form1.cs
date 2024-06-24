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
using ProyectoFinal;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
       



        public Form1()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioConLogin(new Empleados());
        }
    

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
       private void AbrirFormularioConLogin(Form formulario)
        {
            {
                login loginForm = new login();

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    if (loginForm.VerificarCredenciales(loginForm.usuario, loginForm.clave))
                    {
                        formulario.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas.");
                    }
                }
            }
    }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


