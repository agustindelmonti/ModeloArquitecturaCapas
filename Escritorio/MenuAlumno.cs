using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using UserControlsDesktop;

namespace Escritorio
{
    public partial class MenuAlumno : Form
    {
        public Usuario UsuarioAutenticado { get; set; }

        public MenuAlumno(Usuario usr)
        {
            InitializeComponent();
            UsuarioAutenticado = usr;

            panel1.Controls.Add(new Principal(UsuarioAutenticado));
        }


        private void Usuarios_Click(object sender, EventArgs e)
        {
            //Usuarios u = new Usuarios();
            //u.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            //Plan p = new Plan();
            //p.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            //UI.Desktop.Especialidad esp = new UI.Desktop.Especialidad();
            //esp.ShowDialog();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Principal(UsuarioAutenticado));
        }
    }
}
