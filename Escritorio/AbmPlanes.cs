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

//habria q agregar la opcion de elgir las materias que van a corresponder a este plan
//probar que ande
namespace Escritorio
{
    public partial class AbmPlanes : ManejadorForm
    {
        public AbmPlanes()
        {
            InitializeComponent();
            EspecialidadLogic el = new EspecialidadLogic();

            List<Especialidad> listaesp =(List<Especialidad>) el.GetAll();     
            cbEspecialidad.DataSource = listaesp;
            cbEspecialidad.DisplayMember = "Descripcion";
        }

        public Plan PlanActual { get; set; }

        public AbmPlanes(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AbmPlanes(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanLogic plan = new PlanLogic();
            PlanActual = plan.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.PlanID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;
            cbEspecialidad.SelectedItem = PlanActual.Especialidad;//esto no creo q ande

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
                    Plan plan = new Plan();
                    PlanActual = plan;
                    PlanActual.State = BusinessEntity.States.New;
                }
                else
                {
                    PlanActual.PlanID = int.Parse(txtID.Text);
                    PlanActual.State = BusinessEntity.States.Modified;
                }

                PlanActual.Descripcion = txtDescripcion.Text;
                PlanActual.Especialidad = ((Especialidad)cbEspecialidad.SelectedItem);
            }
            else if (Modo == ModoForm.Baja)
            {
                PlanActual.State = BusinessEntity.States.Deleted;

            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic plan = new PlanLogic();
            if (Modo == ModoForm.Alta)
            {
                plan.Add(PlanActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                plan.Update(PlanActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                plan.Delete(PlanActual.PlanID);
            }
        }

        public override bool Validar()
        {

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cbEspecialidad.Text))
            {
                Notificar("ERROR!", "Debe seleccionar el ID de la especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
