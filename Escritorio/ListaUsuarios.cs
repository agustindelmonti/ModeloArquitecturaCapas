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
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.GetAll();
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
            AbmUsuarios formUsuario = new AbmUsuarios(ManejadorForm.ModoForm.Alta);
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 1)
            {
                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                AbmUsuarios formUsuario = new AbmUsuarios(ID, ManejadorForm.ModoForm.Baja);
                formUsuario.ShowDialog();
                this.Listar();
            }


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 1)
            {
                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                AbmUsuarios formUsuario = new AbmUsuarios(ID, ManejadorForm.ModoForm.Modificacion);
                formUsuario.ShowDialog();
                this.Listar();
            }
        }
    }
}
