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
    public partial class ListadoPersonas : UserControl
    {
        public PersonaLogic PersonaLogic { get; set; }
        public ModoForm Modo { get; set; }
        public PersonaDetalle detalle { get; set; }

        public ListadoPersonas()
        {
            InitializeComponent();

            PersonaLogic = new PersonaLogic();
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.MultiSelect = false;
            Modo = ModoForm.Consulta;

            this.Listar();
            detalle = new PersonaDetalle();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        PersonaLogic.Add(detalle.ObtenerDatos());
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        PersonaLogic.Update(detalle.ObtenerDatos());
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
            dgvPersonas.DataSource = (List<Persona>) PersonaLogic.GetAll();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if(this.Modo != ModoForm.Alta)
            {
                this.Modo = ModoForm.Alta;
                LiberarRecurso();
                detalle = new PersonaDetalle(ModoForm.Alta);
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
                dgvPersonas.MultiSelect = true;
                btnAceptar.Show();
            }
            else
            {
                LiberarRecurso();
                dgvPersonas.MultiSelect = false;
                this.Modo = ModoForm.Consulta;
            }
            CambioContext();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.Modo != ModoForm.Modificacion)
            {
                Editar();
                this.Modo = ModoForm.Modificacion;
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
            LiberarRecurso();
            Persona Seleccion = (Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem;
            detalle = new PersonaDetalle(Seleccion, ModoForm.Modificacion);
            panel1.Controls.Add(detalle);
            btnAceptar.Show();
        }

        //Borra un conjunto de registros seleccionados
        private void Borrar()
        {
            int filasSeleccionadas = dgvPersonas.SelectedRows.Count;
            if (filasSeleccionadas >= 1)
            {
                List<Persona> Seleccion = new List<Persona>(filasSeleccionadas);

                for (int i = 0; i < filasSeleccionadas; i++)
                {
                    var selectedRow = dgvPersonas.SelectedRows[i];
                    var Persona = (Persona)selectedRow.DataBoundItem;

                    Seleccion.Add(Persona);
                }
                PersonaLogic.DeleteRange(Seleccion);
                dgvPersonas.MultiSelect = false;
            }
            else
            {
                MessageBox.Show("Para borrar seleccione un conjunto de filas.");
            }
        }

        private void VerDetalle()
        {
            LiberarRecurso();
            if (this.dgvPersonas.SelectedRows.Count == 1)
            {
                Persona Seleccion = (Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem;
                PersonaDetalle detalle = new PersonaDetalle(Seleccion, ModoForm.Consulta);
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
