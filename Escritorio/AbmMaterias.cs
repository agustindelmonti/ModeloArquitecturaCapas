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

// agregar que se pueda seleccionar los cursos en los q esta esta materia
//probar que ande
namespace Escritorio
{
    public partial class AbmMaterias : ManejadorForm
    {
        public AbmMaterias()
        {
            InitializeComponent();

            PlanLogic p = new PlanLogic();

            List<Plan> planes =(List<Plan>) p.GetAll();
            foreach (Plan pl in planes)
            {
                cbPlan.Items.Add(pl.PlanID);
            }
        }

        public Materia MateriaActual { get; set; }

        public AbmMaterias(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AbmMaterias(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaLogic mate = new MateriaLogic();
            MateriaActual = mate.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = MateriaActual.MateriaID.ToString();
            txtDescripcion.Text = MateriaActual.Descripcion;
            txtHsSemanales.Text = MateriaActual.HsSemanales.ToString();
            txtHsTotales.Text = MateriaActual.HsTotales.ToString();
            cbPlan.SelectedValue = MateriaActual.Plan;//no creo q esto ande

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
                    Materia mate = new Materia();
                    MateriaActual = mate;
                    MateriaActual.State = BusinessEntity.States.New;
                }
                else
                {
                    MateriaActual.MateriaID = int.Parse(txtID.Text);
                    MateriaActual.State = BusinessEntity.States.Modified;
                }

                MateriaActual.Descripcion = txtDescripcion.Text;
                MateriaActual.HsSemanales = int.Parse(txtHsSemanales.Text);
                MateriaActual.HsTotales = int.Parse(txtHsTotales.Text);
                MateriaActual.Plan = (Plan)cbPlan.SelectedItem;
            }
            else if (Modo == ModoForm.Baja)
            {
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic mate = new MateriaLogic();
            if (Modo == ModoForm.Alta)
            {
                mate.Add(MateriaActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                mate.Update(MateriaActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                mate.Delete(MateriaActual.MateriaID);
            }
        }

        public override bool Validar()
        {

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtHsSemanales.Text))
            {
                Notificar("ERROR!", "Debe ingresar la cantidad de horas semanales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtHsTotales.Text))
            {
                Notificar("ERROR!", "Debe ingresar la cantidad de horas totales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(cbPlan.Text))
            {
                Notificar("ERROR!", "Debe seleccionar el plan al que corresponde", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
