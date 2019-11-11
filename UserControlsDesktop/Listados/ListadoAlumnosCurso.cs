using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities;
using System.Text.RegularExpressions;

namespace UserControlsDesktop.Listados {
    public partial class ListadoAlumnosCurso : UserControl {
        private InscripcionLogic inscripcionLogic;
        private Boolean editMode;
        List<AlumnoInscripcion> alumnosCurso;
        List<AlumnoInscripcion> updateAlumnosInscripcion;

        public ListadoAlumnosCurso(int cursoID, int docenteID) {
            InitializeComponent();


            inscripcionLogic = new InscripcionLogic();
            updateAlumnosInscripcion = new List<AlumnoInscripcion>();

            dgvAlumnosCurso.AutoGenerateColumns = false;
            cargarAlumnos(cursoID, docenteID);
        }

        private void cargarAlumnos(int cursoID, int docenteID) {
            alumnosCurso = inscripcionLogic.FindInscripcionesByCursoIDAndPersonaID(cursoID, docenteID).ToList();

            dgvAlumnosCurso.DataSource = alumnosCurso;
        }

        private void dgvAlumnosCurso_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in dgvAlumnosCurso.Rows) {
                row.Cells["ID"].Value = ((AlumnoInscripcion)row.DataBoundItem).AlumnoInscripcionID;
                row.Cells["Legajo"].Value = ((AlumnoInscripcion)row.DataBoundItem).Persona.Legajo;
                row.Cells["Alumno"].Value = ((AlumnoInscripcion)row.DataBoundItem).Persona.NombreApellido;
                row.Cells["Nota"].Value = ((AlumnoInscripcion)row.DataBoundItem).Nota != null ? ((AlumnoInscripcion)row.DataBoundItem).Nota.ToString() : "Sin Calificar";
                row.Cells["Condicion"].Value = ((AlumnoInscripcion)row.DataBoundItem).Condicion;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            editMode = !editMode;
            btnGuardarCambios.Visible = !btnGuardarCambios.Visible;

            if (editMode) {
                dgvAlumnosCurso.Columns["Nota"].ReadOnly = false;

                btnEditar.BackColor = Color.SpringGreen;

            }
            else {
                dgvAlumnosCurso.Columns["Nota"].ReadOnly = true;

                btnEditar.BackColor = Color.Transparent;

            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e) {

            foreach (DataGridViewRow row in dgvAlumnosCurso.Rows) {
                string notaCellValue = row.Cells["Nota"].Value.ToString();

                int notaInt;
                if (Int32.TryParse(notaCellValue, out notaInt)) { 

                    if(notaInt >= 1 && notaInt <=10) {
                        int alumnoInscripcionID = Convert.ToInt32(row.Cells["ID"].Value);
                        int nota = Convert.ToInt32(row.Cells["Nota"].Value);

                        updateAlumnosInscripcion.Add(new AlumnoInscripcion { AlumnoInscripcionID = alumnoInscripcionID, Nota = nota });
                    }
                }
            }

            inscripcionLogic.AsignarNotas(updateAlumnosInscripcion);
            MessageBox.Show("Notas Actualizadas", "Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
