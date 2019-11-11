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
using BusinessLogic;
using UserControlsDesktop;

namespace Escritorio
{
    public partial class MenuNoDocente : Form
    {
        public Usuario UsuarioAutenticado { get; set; }

        public MenuNoDocente(Usuario usr)
        {
            InitializeComponent();
            UsuarioAutenticado = usr;

            panel1.Controls.Add(new Principal(UsuarioAutenticado));
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListadoMaterias());
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Principal(UsuarioAutenticado));
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new listaEspecialidades());
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListadoUsuarios());
        }

        private void crearCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListadoPersonas());
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListadoComisiones());
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ReporteCursos());
        }

        private void verCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListadoCursos());
        }

        private void verPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListadoPlanes());
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ReportePlanes());
        }

        private void inscrpcionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new BuscarAlumno());
        }
    }
}
