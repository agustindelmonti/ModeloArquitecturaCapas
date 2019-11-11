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
using UserControlsDesktop.Docente;
using static UserControlsDesktop.Docente.CursosDocente;
using Utils.EventArgs;

namespace Escritorio
{
    public partial class MenuDocente : Form
    {
        public Usuario UsuarioAutenticado { get; set; }

        public MenuDocente(Usuario usr)
        {
            InitializeComponent();
            UsuarioAutenticado = usr;

            panel1.Controls.Add(new Principal(UsuarioAutenticado));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
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

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CursosDocente cursoDocenteUserControl = new CursosDocente(UsuarioAutenticado);
            cursoDocenteUserControl.VerAlumnos += new EventHandler<AlumnosCursoEventArgs>(mostrarAlumnosCurso);
            panel1.Controls.Add(cursoDocenteUserControl);
        }

        public void mostrarAlumnosCurso(Object sender, AlumnosCursoEventArgs alumnosCursoEventArgs) {
            int cursoID = alumnosCursoEventArgs.CursoID;
            int docenteID = alumnosCursoEventArgs.DocenteID;

            AlumnosCurso alumnosCurso = new AlumnosCurso(cursoID, docenteID);
            alumnosCurso.ShowDialog();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new Perfil(UsuarioAutenticado));
        }
    }
}
