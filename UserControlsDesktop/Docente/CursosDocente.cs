using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;
using Utils.EventArgs;

namespace UserControlsDesktop.Docente {
    public partial class CursosDocente : UserControl {
        private Usuario user;
        private Persona persona;
        private CursoLogic cursoLogic;
        private UsuarioLogic usuarioLogic;

        
        public event EventHandler<AlumnosCursoEventArgs> VerAlumnos;

        public CursosDocente(Usuario UsuarioAutenticado) {
            InitializeComponent();

            user = UsuarioAutenticado;
            cursoLogic = new CursoLogic();
            usuarioLogic = new UsuarioLogic();
            persona = usuarioLogic.GetPersonaByUserID(user.UsuarioID);

            dgvCursos.AutoGenerateColumns = false;
            ListarCursos();
        }


        private void ListarCursos() {
            IEnumerable<Curso> cursosDocente = cursoLogic.FindCursosActualesDocenteByPersonaID(persona.PersonaID);

            dgvCursos.DataSource = cursosDocente;

        }

        private void dgvCursos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach(DataGridViewRow row in dgvCursos.Rows) {
                row.Cells["Materia"].Value = ((Curso)row.DataBoundItem).Materia.Descripcion;
                row.Cells["Comision"].Value = ((Curso)row.DataBoundItem).Comision.Descripcion;
                row.Cells["Especialidad"].Value = ((Curso)row.DataBoundItem).Comision.Plan.Especialidad.Descripcion;
                row.Cells["AñoCalendario"].Value = ((Curso)row.DataBoundItem).AnioCalendario;
               
            }
        }

        
        private void dgvCursos_SelectionChanged(object sender, EventArgs e) {
            dgvCursos.ClearSelection();
        }


        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            // Verifica que la celda sea un botón y no sea el header
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                
                //Null check makes sure the main page is attached to the event
                if (VerAlumnos != null) {
                    int cursoID = ((Curso)senderGrid.Rows[e.RowIndex].DataBoundItem).CursoID;
                    int docenteID = persona.PersonaID;


                    VerAlumnos(sender, new AlumnosCursoEventArgs { CursoID = cursoID, DocenteID = docenteID });
                }
            }
        }
    }

}
