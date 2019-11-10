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
    public partial class MisCursos : UserControl {
        private Usuario user;
        private Persona persona;
        private UsuarioLogic usuarioLogic;
        private CursoLogic cursoLogic;

        public MisCursos(Usuario UsuarioAutenticado) {
            InitializeComponent();

            user = UsuarioAutenticado;
            usuarioLogic = new UsuarioLogic();
            cursoLogic = new CursoLogic();
            persona = usuarioLogic.GetPersonaByUserID(user.UsuarioID);
            
            
            dgvMisCursos.AutoGenerateColumns = false;
            cargarCursos();
        }


        public void cargarCursos() {
            IEnumerable<Curso> cursosActuales = cursoLogic.FindCursosActualesAlumnoByPersonaID(persona.PersonaID);

            List<CursoActual> cursosActualesList = new List<CursoActual>();
            
            foreach(Curso curso in cursosActuales) {
                cursosActualesList.Add(new CursoActual {
                    NroComision = curso.Comision.Descripcion,
                    NombreMateria = curso.Materia.Descripcion
                });
            }

            dgvMisCursos.DataSource = cursosActualesList;

        }
    }
}
