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
//agregar opcion de seleccionar planes en los q esta esta especialidad
//reparar el update (probar alta y baja x las dudas)
namespace Escritorio
{
    public partial class AbmEspecialidades : ManejadorForm
    {

        public AbmEspecialidades()
        {
            InitializeComponent();
        }

        public Especialidad EspecialidadActual { get; set; }


        public AbmEspecialidades(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AbmEspecialidades(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic es = new EspecialidadLogic();
            EspecialidadActual = es.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = EspecialidadActual.EspecialidadID.ToString();
            txtDescripcion.Text = EspecialidadActual.Descripcion;

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
                    Especialidad esp = new Especialidad();
                    EspecialidadActual = esp;
                }
                else
                {
                    EspecialidadActual.EspecialidadID = int.Parse(txtID.Text);
                }

                EspecialidadActual.Descripcion = txtDescripcion.Text;
            }
            else if (Modo == ModoForm.Baja)
            {
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic es = new EspecialidadLogic();
            if (Modo == ModoForm.Alta)
            {
                es.Add(EspecialidadActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                es.Update(EspecialidadActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                es.Remove(EspecialidadActual.EspecialidadID);
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
