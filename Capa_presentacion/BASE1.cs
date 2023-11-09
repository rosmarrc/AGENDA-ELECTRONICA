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
using Capa_entidad.MODELS;

namespace Capa_presentacion
{
    public partial class BASE1 : Form
    {
        public BASE1()
        {
            InitializeComponent();
        }
        void abrirForm(Form form)
        {
            while (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            Form formhijo = form;
            form.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formhijo);
            formhijo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (conexionDB.panelcase == 2)
            {
                abrirForm(new Registro());
            }

            if (conexionDB.panelcase == 3)
            {
                abrirForm(new agenda());
            }

            if (conexionDB.panelcase == 1)
            {
                abrirForm(new Login());
            }


        }

        private void BASE1_Load(object sender, EventArgs e)
        {
            abrirForm(new Login());

         
        }
    }
}
