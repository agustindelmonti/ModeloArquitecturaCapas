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
    public partial class ListaPlanes : Form
    {
        public ListaPlanes()
        {
            InitializeComponent();
            dvgPlanes.AutoGenerateColumns = false;
            dvgPlanes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgPlanes.MultiSelect = false;
        }



        public void Listar()
        {
            PlanLogic plan = new PlanLogic();
            this.dvgPlanes.DataSource = plan.GetAll();
        }

        private void Plan_Load(object sender, EventArgs e)
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
            AbmPlanes formPlan = new AbmPlanes(ManejadorForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dvgPlanes.SelectedRows.Count == 1)
            {
                int ID = ((Plan)this.dvgPlanes.SelectedRows[0].DataBoundItem).PlanID;
                AbmPlanes formPlan = new AbmPlanes(ID, ManejadorForm.ModoForm.Baja);
                formPlan.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dvgPlanes.SelectedRows.Count == 1)
            {
                int ID = ((Plan)this.dvgPlanes.SelectedRows[0].DataBoundItem).PlanID;
                AbmPlanes formPlan = new AbmPlanes(ID, ManejadorForm.ModoForm.Modificacion);
                formPlan.ShowDialog();
                this.Listar();
            }
        }
    }
}
