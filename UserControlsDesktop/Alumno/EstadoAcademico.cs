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
    public partial class EstadoAcademico : UserControl {
        private Usuario user;
        private Persona persona;
        private UsuarioLogic usuarioLogic;
        private InscripcionLogic inscripcionLogic;



        public EstadoAcademico(Usuario UsuarioAutenticado) {
            InitializeComponent();
            user = UsuarioAutenticado;

            usuarioLogic = new UsuarioLogic();
            inscripcionLogic = new InscripcionLogic();
            persona = usuarioLogic.GetPersonaByUserID(user.UsuarioID);

            dgvEstadoAcademico.AutoGenerateColumns = false;
            cargarInscripciones();
        }

        
        private void cargarInscripciones() { 
            List<AlumnoInscripcion> inscripciones = inscripcionLogic.FindInscripcionesByPersonaID(persona.PersonaID).ToList();


            List<EstadoMateria> estadosMateriasList = new List<EstadoMateria>();
            
            foreach(AlumnoInscripcion inscripcion in inscripciones) {
                estadosMateriasList.Add(new EstadoMateria {
                    AñoEspecialidad = inscripcion.Curso.Comision.AnioEspecialidad,
                    NombreMateria = inscripcion.Curso.Materia.Descripcion,
                    Condicion = inscripcion.Condicion.ToString(),
                    Nota = inscripcion.Nota,
                    NumeroComision = inscripcion.Curso.Comision.Descripcion,
                    AñoCalendario = inscripcion.Curso.AnioCalendario,
                    Plan = inscripcion.Curso.Materia.Plan.Descripcion
                });
            }


            dgvEstadoAcademico.DataSource = estadosMateriasList;
        }

    }
}
