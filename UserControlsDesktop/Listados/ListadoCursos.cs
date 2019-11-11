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
using static UserControlsDesktop.Detalle;
using Utils;

namespace Escritorio
{
    public partial class ListadoCursos : UserControl
    {
        public CursoLogic CursoLogic { get; set; }
        public ModoForm Modo { get; set; }
        public CursoDetalle detalle { get; set; }

        public ListadoCursos()
        {
            InitializeComponent();

            CursoLogic = new CursoLogic();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.MultiSelect = false;
            Modo = ModoForm.Consulta;

            this.Listar();
            detalle = new CursoDetalle();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        CursoLogic.Add(detalle.ObtenerDatos());
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        CursoLogic.Update(detalle.ObtenerDatos());
                        break;
                    }
                case ModoForm.Baja:
                    {
                        Borrar();
                        break;
                    }
            }
            //Refresco los cambios
            Listar();
            this.Modo = ModoForm.Consulta;
            LiberarRecurso();
            CambioContext();
        }

        public void Listar()
        {
            dgvCursos.DataSource = (List<Curso>) CursoLogic.GetAll();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if(this.Modo != ModoForm.Alta)
            {
                this.Modo = ModoForm.Alta;
                LiberarRecurso();
                detalle = new CursoDetalle(ModoForm.Alta);
                panel1.Controls.Add(detalle);
                btnAceptar.Show();
            }
            else
            {
                LiberarRecurso();
                this.Modo = ModoForm.Consulta;
            }
            CambioContext();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.Modo != ModoForm.Baja)
            {
                this.Modo = ModoForm.Baja;
                LiberarRecurso();
                //Admite seleccion multiple
                dgvCursos.MultiSelect = true;
                btnAceptar.Show();
            }
            else
            {
                LiberarRecurso();
                dgvCursos.MultiSelect = false;
                this.Modo = ModoForm.Consulta;
            }
            CambioContext();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.Modo != ModoForm.Modificacion)
            {
                Editar();
            }
            else
            {
                LiberarRecurso();
                this.Modo = ModoForm.Consulta;
            }
            CambioContext();
        }

        //Seleccionar un registro de la tabla me muestra 
        //el detalle el registro seleccionado
        private void dgvMaterias_Click(object sender, EventArgs e)
        {
            if (this.Modo != ModoForm.Modificacion)
            {
                VerDetalle();
            }
            else
            {
                Editar();
            }
        }

        private void Editar()
        {
            this.Modo = ModoForm.Modificacion;
            LiberarRecurso();
            Curso Seleccion = (Curso)this.dgvCursos.SelectedRows[0].DataBoundItem;
            detalle = new CursoDetalle(Seleccion, ModoForm.Modificacion);
            panel1.Controls.Add(detalle);
            btnAceptar.Show();
        }

        //Borra un conjunto de registros seleccionados
        private void Borrar()
        {
            int filasSeleccionadas = dgvCursos.SelectedRows.Count;
            if (filasSeleccionadas >= 1)
            {
                List<Curso> Seleccion = new List<Curso>(filasSeleccionadas);

                for (int i = 0; i < filasSeleccionadas; i++)
                {
                    var selectedRow = dgvCursos.SelectedRows[i];
                    var Curso = (Curso)selectedRow.DataBoundItem;

                    Seleccion.Add(Curso);
                }
                CursoLogic.DeleteRange(Seleccion);
                dgvCursos.MultiSelect = false;
            }
            else
            {
                MessageBox.Show("Para borrar seleccione un conjunto de filas.");
            }
        }

        private void VerDetalle()
        {
            LiberarRecurso();
            if (this.dgvCursos.SelectedRows.Count == 1)
            {
                Curso Seleccion = (Curso)this.dgvCursos.SelectedRows[0].DataBoundItem;
                CursoDetalle detalle = new CursoDetalle(Seleccion, ModoForm.Consulta);
                panel1.Controls.Add(detalle);
            }
        }

        //Se encarga de todo lo visual para cambiar entre modos
        private void CambioContext()
        {
            btnNuevo.BackColor = Color.Transparent;
            btnBorrar.BackColor = Color.Transparent;
            btnEditar.BackColor = Color.Transparent;
            switch (Modo)
            {
                case ModoForm.Alta:
                    btnNuevo.BackColor = Color.Teal;
                    break;
                case ModoForm.Baja:
                    btnBorrar.BackColor = Color.Red;
                    break;
                case ModoForm.Modificacion:
                    btnEditar.BackColor = Color.Blue;
                    break;
            }
        }

        private void LiberarRecurso()
        {
            panel1.Controls.Clear();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvCursos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvCursos.Rows)
            {
                row.Cells["comisionID"].Value = ((Curso)row.DataBoundItem).Comision.Descripcion;
                row.Cells["materiaID"].Value = ((Curso)row.DataBoundItem).Materia.Descripcion;
                row.Cells["Plan"].Value = ((Curso)row.DataBoundItem).Materia.Plan.Descripcion;
            }
        }

    }
}
