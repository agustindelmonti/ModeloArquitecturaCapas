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

namespace Escritorio
{
    public partial class ListaEspecialidades : Form
    {
        public ListaEspecialidades()
        {
            InitializeComponent();
            dvgEspecialidades.AutoGenerateColumns = false;
            dvgEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgEspecialidades.MultiSelect = false;
        }

        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            dvgEspecialidades.DataSource = (List<Especialidad>)el.GetAll();
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            detalle = new EspecialidadDetalle(ModoForm.Alta);
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dvgEspecialidades.SelectedRows.Count == 1)
            {
                int ID = ((Especialidad)this.dvgEspecialidades.SelectedRows[0].DataBoundItem).EspecialidadID;
                AbmEspecialidades abmEspecialidad = new AbmEspecialidades(ID, ManejadorForm.ModoForm.Baja);
                abmEspecialidad.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dvgEspecialidades.SelectedRows.Count == 1)
            {
                int ID = ((Especialidad)this.dvgEspecialidades.SelectedRows[0].DataBoundItem).EspecialidadID;
                AbmEspecialidades abmEspecialidad = new AbmEspecialidades(ID, ManejadorForm.ModoForm.Modificacion);
                abmEspecialidad.ShowDialog();
                this.Listar();
            }
        }
    }
}
