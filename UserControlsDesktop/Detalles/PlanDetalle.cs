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
using Utils.Exceptions;

namespace UserControlsDesktop
{
    public partial class PlanDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Plan PlanActual { get; set; }

        public int Id { set => lbId.Text = value.ToString(); }
        public string Descripcion { get => tbDescripcion.Text; set => tbDescripcion.Text = value; }
        public Especialidad Especialidad { get => (Especialidad)cbEspecialidad.SelectedItem; set => cbEspecialidad.SelectedValue = value.EspecialidadID; }
        

        public Plan ObtenerDatos()
        {
            Plan m = new Plan()
            {
                Descripcion = Descripcion,
                Especialidad = Especialidad
            };

            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        return m;
                    }
                case ModoForm.Modificacion:
                    {
                        m.PlanID = PlanActual.PlanID;
                        m.Personas = PlanActual.Personas;
                        m.Materias = PlanActual.Materias;
                        return m;
                    }
                default: throw new InvalidInputException("Complete todos los campos obligatorios");
            }
        }

        public PlanDetalle(ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta)
            {
                lbId.Hide();
            }
        }

        public PlanDetalle()
        {
            InitializeComponent();

            EspecialidadLogic logic = new EspecialidadLogic();
            List<Especialidad> especialidades = (List<Especialidad>)logic.GetAll();

            foreach (Especialidad e in especialidades)
            {
                cbEspecialidad.Items.Add(e);
            }
            cbEspecialidad.DisplayMember = "Descripcion";

        }

        public PlanDetalle(Plan e, ModoForm modo) : this(modo)
        {
            PlanActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                tbDescripcion.Enabled = false;
                Descripcion = PlanActual.Descripcion;
                Id = PlanActual.PlanID;
            }
            if (Modo == ModoForm.Modificacion)
            {
                tbDescripcion.Enabled = true;
                cbEspecialidad.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
