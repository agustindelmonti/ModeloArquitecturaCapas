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

//Probar que ande
namespace Escritorio
{
    public partial class AbmComisiones : ManejadorForm
    {
        public AbmComisiones()
        {
            InitializeComponent();
        }

        public Comision ComisionActual { get; set; }


        public AbmComisiones(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AbmComisiones(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionLogic com = new ComisionLogic();
            ComisionActual = com.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = ComisionActual.ComisionID.ToString();
            txtDescripcion.Text = ComisionActual.Descripcion.ToString();
            txtAño.Text = ComisionActual.AnioEspecialidad.ToString();
            cbPlan.SelectedItem = ComisionActual.Plan; //no creo q esto ande

            if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
        }


        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {

                if (Modo == ModoForm.Alta)
                {
                    Comision com = new Comision();
                    ComisionActual = com;
                }
                else
                {
                    ComisionActual.ComisionID = int.Parse(txtID.Text);
                }

                ComisionActual.Descripcion = txtDescripcion.Text;
                ComisionActual.AnioEspecialidad = int.Parse(txtAño.Text);
                ComisionActual.Plan = (Plan)cbPlan.SelectedItem;
            }
            else if (Modo == ModoForm.Baja)
            {
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic com = new ComisionLogic();
            if (Modo == ModoForm.Alta)
            {
                com.Add(ComisionActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                com.Update(ComisionActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                com.Delete(ComisionActual.ComisionID);
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar una descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAño.Text))
            {
                Notificar("ERROR!", "Debe ingresar el año de cursado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cbPlan.Text))
            {
                Notificar("ERROR!", "Debe seleccionar un plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}