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
    public partial class ListadoMaterias : UserControl
    {
        public MateriaLogic MateriaLogic { get; set; }
        public ModoForm Modo { get; set; }
        public MateriaDetalle detalle { get; set; }

        public ListadoMaterias()
        {
            InitializeComponent();

            MateriaLogic = new MateriaLogic();
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.MultiSelect = false;
            Modo = ModoForm.Consulta;

            this.Listar();
            detalle = new MateriaDetalle();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        MateriaLogic.Add(detalle.ObtenerDatos());
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        MateriaLogic.Update(detalle.ObtenerDatos());
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
            dgvMaterias.DataSource = (List<Materia>) MateriaLogic.GetAll();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if(this.Modo != ModoForm.Alta)
            {
                this.Modo = ModoForm.Alta;
                LiberarRecurso();
                detalle = new MateriaDetalle(ModoForm.Alta);
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
                dgvMaterias.MultiSelect = true;
                btnAceptar.Show();
            }
            else
            {
                LiberarRecurso();
                dgvMaterias.MultiSelect = false;
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
        private void dvgMaterias_Click(object sender, EventArgs e)
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
            Materia Seleccion = (Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem;
            detalle = new MateriaDetalle(Seleccion, ModoForm.Modificacion);
            panel1.Controls.Add(detalle);
            btnAceptar.Show();
        }

        //Borra un conjunto de registros seleccionados
        private void Borrar()
        {
            int filasSeleccionadas = dgvMaterias.SelectedRows.Count;
            if (filasSeleccionadas >= 1)
            {
                List<Materia> Seleccion = new List<Materia>(filasSeleccionadas);

                for (int i = 0; i < filasSeleccionadas; i++)
                {
                    var selectedRow = dgvMaterias.SelectedRows[i];
                    var Materia = (Materia)selectedRow.DataBoundItem;

                    Seleccion.Add(Materia);
                }
                MateriaLogic.DeleteRange(Seleccion);
                dgvMaterias.MultiSelect = false;
            }
            else
            {
                MessageBox.Show("Para borrar seleccione un conjunto de filas.");
            }
        }

        private void VerDetalle()
        {
            LiberarRecurso();
            if (this.dgvMaterias.SelectedRows.Count == 1)
            {
                Materia Seleccion = (Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem;
                MateriaDetalle detalle = new MateriaDetalle(Seleccion, ModoForm.Consulta);
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


        private void Materia_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
