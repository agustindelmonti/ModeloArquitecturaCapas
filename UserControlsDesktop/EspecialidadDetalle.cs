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
using Utils;
using BusinessLogic;

namespace UserControlsDesktop
{
    public partial class EspecialidadDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Especialidad EspecialidadActual {get; set;}

        public int Id { set => lbId.Text = value.ToString(); }
        public string Descripcion { get => tbDescripcion.Text; set => tbDescripcion.Text = value; }

        public Especialidad ObtenerDatos()
        {
            Validar();
            Especialidad n = new Especialidad();
            n.Descripcion = tbDescripcion.Text;
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        return n;
                    }
                case ModoForm.Modificacion:
                    {
                        n.EspecialidadID = EspecialidadActual.EspecialidadID;
                        return n;
                    }
                default: throw new Exception();
            }
        }

        public EspecialidadDetalle(ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta)
            {
                lbId.Hide();
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

        public EspecialidadDetalle()
        {
            InitializeComponent();
        }

        public EspecialidadDetalle(Especialidad e, ModoForm modo) : this(modo)
        {
            EspecialidadActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                tbDescripcion.Enabled = false;
                Descripcion = EspecialidadActual.Descripcion;
                Id = EspecialidadActual.EspecialidadID;
            }
            if (Modo == ModoForm.Modificacion)
            {
                tbDescripcion.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
