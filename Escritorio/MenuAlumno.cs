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
using UserControlsDesktop.Alumno;

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

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Principal(UsuarioAutenticado));
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estadoAcademicoToolStripMenuItem_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            panel1.Controls.Add(new EstadoAcademico(UsuarioAutenticado));
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Inscripcion(UsuarioAutenticado));
        }

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e) {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MisCursos(UsuarioAutenticado));
        }
    }
}
