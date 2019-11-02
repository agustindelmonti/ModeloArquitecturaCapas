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
    public partial class listaEspecialidades : Form
    {
        public EspecialidadLogic EspecialidadLogic { get; set; }
        public ModoForm Modo { get; set; }
        public EspecialidadDetalle detalle { get; set; }

        public listaEspecialidades()
        {
            InitializeComponent();

            EspecialidadLogic = new EspecialidadLogic();
            dvgEspecialidades.AutoGenerateColumns = false;
            dvgEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgEspecialidades.MultiSelect = false;
            Modo = ModoForm.Consulta;

            detalle = new EspecialidadDetalle();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        EspecialidadLogic.Add(detalle.ObtenerDatos());
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        EspecialidadLogic.Update(detalle.ObtenerDatos());
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
            CambioContext();
        }

        public void Listar()
        {
            dvgEspecialidades.DataSource = (List<Especialidad>)EspecialidadLogic.GetAll();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if(this.Modo != ModoForm.Alta)
            {
                this.Modo = ModoForm.Alta;
                LiberarRecurso();
                detalle = new EspecialidadDetalle(ModoForm.Alta);
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
                dvgEspecialidades.MultiSelect = true;
                btnAceptar.Show();
            }
            else
            {
                LiberarRecurso();
                dvgEspecialidades.MultiSelect = false;
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
        private void dvgEspecialidades_Click(object sender, EventArgs e)
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
            Especialidad Seleccion = (Especialidad)this.dvgEspecialidades.SelectedRows[0].DataBoundItem;
            detalle = new EspecialidadDetalle(Seleccion, ModoForm.Modificacion);
            panel1.Controls.Add(detalle);
            btnAceptar.Show();
        }

        //Borra un conjunto de registros seleccionados
        private void Borrar()
        {
            int filasSeleccionadas = dvgEspecialidades.SelectedRows.Count;
            if (filasSeleccionadas >= 1)
            {
                List<Especialidad> Seleccion = new List<Especialidad>(filasSeleccionadas);

                for (int i = 0; i < filasSeleccionadas; i++)
                {
                    var selectedRow = dvgEspecialidades.SelectedRows[i];
                    var especialidad = (Especialidad)selectedRow.DataBoundItem;

                    Seleccion.Add(especialidad);
                }
                EspecialidadLogic.DeleteRange(Seleccion);
                dvgEspecialidades.MultiSelect = false;
            }
            else
            {
                MessageBox.Show("Para borrar seleccione un conjunto de filas.");
            }
        }

        private void VerDetalle()
        {
            LiberarRecurso();
            if (this.dvgEspecialidades.SelectedRows.Count == 1)
            {
                Especialidad Seleccion = (Especialidad)this.dvgEspecialidades.SelectedRows[0].DataBoundItem;
                EspecialidadDetalle detalle = new EspecialidadDetalle(Seleccion, ModoForm.Consulta);
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


        private void Especialidad_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
