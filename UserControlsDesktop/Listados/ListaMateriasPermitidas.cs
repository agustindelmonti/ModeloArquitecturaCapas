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

namespace Escritorio
{
    public partial class ListaMateriasPermitidas : UserControl
    {
        public Usuario UsuarioAutenticado { get; set; }

        public ListaMateriasPermitidas(Usuario u)
        {
            InitializeComponent();

            UsuarioAutenticado = u;

            dgvInscripcion.AutoGenerateColumns = false;
            dgvInscripcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripcion.MultiSelect = false;
            this.Listar();
        }

        public void Listar()
        {
            CursoLogic cursoLogic = new CursoLogic();
            List<Curso> listaCursos = (List<Curso>)cursoLogic.FindCursosHabilitadosByPersonaID(UsuarioAutenticado.PersonaID);
            dgvInscripcion.DataSource = listaCursos;
            if (listaCursos.Count() == 0)
            {
                MessageBox.Show("El alumno no tiene cursos habilitados para inscripcion");
            }
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            InscripcionLogic inscripcionLogic = new InscripcionLogic();

            int cursoID = ((Entities.Curso)this.dgvInscripcion.SelectedRows[0].DataBoundItem).CursoID;
            Persona persona = usuarioLogic.GetPersonaByUserID(UsuarioAutenticado.UsuarioID);
            inscripcionLogic.InscribirAlumno(persona.PersonaID, cursoID);
            MessageBox.Show("Inscripcion realizada");
            this.Listar();
        }

        public void dgvInscripcion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvInscripcion.Rows)
            {
                row.Cells["Materia"].Value = ((Curso)row.DataBoundItem).Materia.Descripcion;
            }     
        }
    }
}
