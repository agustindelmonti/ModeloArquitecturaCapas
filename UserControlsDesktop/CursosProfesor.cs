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
using Utils;

namespace UserControlsDesktop
{
    public partial class CursosProfesor : UserControl
    {
        public CursosProfesor(Usuario usuario)
        {
            InitializeComponent();

            CursoLogic logica = new CursoLogic();
            dgvCursos.DataSource = (List<DocenteCurso>) logica.GetAllCursosActualesByProfesor(usuario.Persona);
        }

        private void dgvCursos_Click(object sender, EventArgs e)
        {
            VerDetalle();
        }

        private void VerDetalle()
        {
            LiberarRecurso();
            if (this.dgvCursos.SelectedRows.Count == 1)
            {
                DocenteCurso Seleccion = (DocenteCurso)this.dgvCursos.SelectedRows[0].DataBoundItem;
                detalle = new CursoDetalle(Seleccion.Curso, ModoForm.Consulta);
                panel1.Controls.Add(detalle);
            }
        }

        private void LiberarRecurso()
        {
            panel1.Controls.Clear();
        }

        private void cursoDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
