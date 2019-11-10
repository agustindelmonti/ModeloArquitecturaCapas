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
using Entities.ViewModels;

namespace UserControlsDesktop.Alumno {
    public partial class Inscripcion : UserControl {
        private Usuario user;
        private UsuarioLogic usuarioLogic;
        private CursoLogic cursoLogic;
        private Persona persona;

        public Inscripcion(Usuario UsuarioAutenticado) {
            InitializeComponent();

            user = UsuarioAutenticado;
            usuarioLogic = new UsuarioLogic();
            cursoLogic = new CursoLogic();
            persona = usuarioLogic.GetPersonaByUserID(user.UsuarioID);


            dgvInscripcion.AutoGenerateColumns = false;
            CargarInscripcionesDisponibles();
        }

        public void CargarInscripcionesDisponibles() { 
            IEnumerable<Curso> cursosHabilitadosInscripcion = cursoLogic.FindCursosHabilitadosByPersonaID(persona.PersonaID);

            List<CursoDisponible> cursosHabilitadosInscripcionList = new List<CursoDisponible>();

            foreach(Curso curso in cursosHabilitadosInscripcion) {
                cursosHabilitadosInscripcionList.Add(new CursoDisponible {
                    Curso = curso,
                    NombreMateria = curso.Materia.Descripcion,
                    NroComision = curso.Comision.Descripcion,
                    Titular = curso.DocentesDelCurso.Where(d => d.Cargo == DocenteCurso.TipoCargo.Titular).Select(d => d.Docente.Nombre + d.Docente.Apellido).SingleOrDefault(),
                    Auxiliar = curso.DocentesDelCurso.Where(d => d.Cargo == DocenteCurso.TipoCargo.Auxiliar).Select(d => d.Docente.Nombre + d.Docente.Apellido).SingleOrDefault(),
                    Ayudante = curso.DocentesDelCurso.Where(d => d.Cargo == DocenteCurso.TipoCargo.Ayudante).Select(d => d.Docente.Nombre + d.Docente.Apellido).SingleOrDefault(),
                });
            }

            cursosHabilitadosInscripcionList = cursosHabilitadosInscripcionList.OrderBy(c => c.NombreMateria).ToList();
            dgvInscripcion.DataSource = cursosHabilitadosInscripcionList;
        }

        private void dgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            // Verifica que la celda sea un botón y no sea el header
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&  e.RowIndex >= 0) {
                AlumnoInscripcion nuevaInscripcion = new AlumnoInscripcion {
                    Condicion = AlumnoInscripcion.Estado.Cursando,
                    Persona = persona,
                    Curso = ((CursoDisponible)senderGrid.Rows[e.RowIndex].DataBoundItem).Curso
                };
                
                InscripcionLogic inscripcionLogic = new InscripcionLogic();

                inscripcionLogic.Add(nuevaInscripcion);

                MessageBox.Show("Inscripcion realizada con éxito", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInscripcionesDisponibles();
            }
        }
    }
}
