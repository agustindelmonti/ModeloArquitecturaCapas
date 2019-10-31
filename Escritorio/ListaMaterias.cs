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
    public partial class ListaMaterias : Form
    {
        public ListaMaterias()
        {
            InitializeComponent();
            dvgMaterias.AutoGenerateColumns = false;
            dvgMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMaterias.MultiSelect = false;
        }



        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dvgMaterias.DataSource = ml.GetAll();
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
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AbmMaterias formMateria = new AbmMaterias(ManejadorForm.ModoForm.Alta);
            formMateria.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dvgMaterias.SelectedRows.Count == 1)
            {
                int ID = ((Materia)this.dvgMaterias.SelectedRows[0].DataBoundItem).MateriaID;
                AbmMaterias formMateria = new AbmMaterias(ID, ManejadorForm.ModoForm.Baja);
                formMateria.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dvgMaterias.SelectedRows.Count == 1)
            {
                int ID = ((Materia)this.dvgMaterias.SelectedRows[0].DataBoundItem).MateriaID;
                AbmMaterias formMateria = new AbmMaterias(ID, ManejadorForm.ModoForm.Modificacion);
                formMateria.ShowDialog();
                this.Listar();
            }
        }
    }
}
