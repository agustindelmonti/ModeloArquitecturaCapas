using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;

namespace UserControlsDesktop
{
    public partial class EspecialidadDetalle: Detalle
    {
        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadLogic EspecialidadLogic { get; set; }

        public EspecialidadDetalle()
        {
            InitializeComponent();
        }

        public EspecialidadDetalle(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public EspecialidadDetalle(Especialidad e, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadActual = e;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar()) GuardarCambios();
        }
        

        public override void MapearDeDatos()
        {
            tbId.Text = EspecialidadActual.EspecialidadID.ToString();
            tbDescripcion.Text = EspecialidadActual.Descripcion;

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
                    EspecialidadActual.EspecialidadID = int.Parse(tbId.Text);
                }

                EspecialidadActual.Descripcion = tbDescripcion.Text;
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
            if (string.IsNullOrEmpty(tbDescripcion.Text))
            {
                Notificar("ERROR!", "Debe ingresar Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
