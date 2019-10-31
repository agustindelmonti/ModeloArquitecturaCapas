using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities;

namespace Escritorio
{
    public partial class ListaPersonas : Form
    {
        public ListaPersonas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.MultiSelect = false;
        }

        public void Listar()
        {
            PersonaLogic per = new PersonaLogic();
            this.dgvPersonas.DataSource = per.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AbmPersonas formPersonas = new AbmPersonas(ManejadorForm.ModoForm.Alta);
            formPersonas.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonas.SelectedRows.Count == 1)
            {
                int ID = ((Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).PersonaID;
                AbmPersonas formPersonas = new AbmPersonas(ID, ManejadorForm.ModoForm.Baja);
                formPersonas.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonas.SelectedRows.Count == 1)
            {
                int ID = ((Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).PersonaID;
                AbmPersonas formPersonas = new AbmPersonas(ID, ManejadorForm.ModoForm.Modificacion);
                formPersonas.ShowDialog();
                this.Listar();
            }
        }
    }
}
