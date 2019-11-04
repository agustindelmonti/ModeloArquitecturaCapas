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
    public partial class ComisionDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Comision ComisionActual { get; set; }

        public string Descripcion {
            get => String.Concat(maskComision.Text[1], maskComision.Text[2]);
        }
        public string NroComision {
            set => maskComision.Text = value;
        }
        public Plan Plan { get => (Plan) cbPlan.SelectedItem; set => cbPlan.SelectedItem = value; }
        public int Anio { get => int.Parse(maskComision.Text[0].ToString());}

        public Comision ObtenerDatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        PersonaLogic PersonaLogic = new PersonaLogic();
                        return new Comision()
                        {
                            AnioEspecialidad = Anio,
                            Plan = Plan,
                            Descripcion = Descripcion
                        };
                    }
                case ModoForm.Modificacion:
                    {
                        ComisionActual.AnioEspecialidad = Anio;
                        ComisionActual.Plan = Plan;
                        ComisionActual.Descripcion = Descripcion;
                        return ComisionActual;
                    }
                default: throw new InvalidInputException("Complete todos los campos obligatorios");
            }
        }

        public ComisionDetalle(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ComisionDetalle()
        {
            InitializeComponent();
            PlanLogic logic = new PlanLogic();
            cbPlan.DataSource = (List<Plan>) logic.GetAll(); ;
            cbPlan.DisplayMember = "Descripcion";
        }

        public ComisionDetalle(Comision e, ModoForm modo) : this(modo)
        {
            ComisionActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                maskComision.Enabled = false;
                NroComision = String.Concat(e.AnioEspecialidad.ToString(),e.Descripcion);
                Plan = e.Plan;
            }
            if (Modo == ModoForm.Consulta)
            {
                cbPlan.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
