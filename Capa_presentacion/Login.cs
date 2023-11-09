using Capa_entidad.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_datos.Conexion;

namespace Capa_presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            conexionDB.panelcase = 2;

        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.Show();
            txtusuario.Focus();
            txtusuario.Text = "";
            txtclave.Text = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void registrar_Click_1(object sender, EventArgs e)
        {
      
        }

        private void registrar_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            conexionDB.panelcase = 2;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtusuario.Text != "")
            {
                if (txtclave.Text != "")
                {
                    DloginUsuario usuariomodelo = new DloginUsuario();
                    var validar = usuariomodelo.Login(txtusuario.Text, txtclave.Text);
                    if (validar)
                    {
                        this.Hide();
                        conexionDB.panelcase = 3;
                    }
                    else MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Contraseña Incorrecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else MessageBox.Show("Usuario incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
