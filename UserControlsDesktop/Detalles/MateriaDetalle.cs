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
    public partial class MateriaDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Materia MateriaActual { get; set; }

        public int Id { set => lbId.Text = value.ToString(); }
        public string Descripcion { get => tbDescripcion.Text; set => tbDescripcion.Text = value; }
        public int HsSemanal { get => int.Parse(tbSemana.Text); set => tbSemana.Text = value.ToString(); }
        public int HsTotal { get => int.Parse(tbTotal.Text); set => tbTotal.Text = value.ToString(); }
        public Plan Plan { get => (Plan)cbPlan.SelectedItem; set => cbPlan.SelectedValue = value.PlanID; }
        

        public Materia ObtenerDatos()
        {
            Materia m = new Materia()
            {
                Descripcion = Descripcion,
                HsSemanales = HsSemanal,
                HsTotales = HsTotal,
                Plan = Plan
            };

            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        return m;
                    }
                case ModoForm.Modificacion:
                    {
                        m.MateriaID = MateriaActual.MateriaID;
                        m.Cursos = MateriaActual.Cursos;
                        return m;
                    }
                default: throw new Exception();
            }
        }

        public MateriaDetalle(ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta)
            {
                lbId.Hide();
            }
        }

        public MateriaDetalle()
        {
            InitializeComponent();

            PlanLogic p = new PlanLogic();
            List<Plan> planes = (List<Plan>)p.GetAll();

            foreach (Plan pl in planes)
            {
                cbPlan.Items.Add(pl);
            }
        }

        public MateriaDetalle(Materia e, ModoForm modo) : this(modo)
        {
            MateriaActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                tbDescripcion.Enabled = false;
                Descripcion = MateriaActual.Descripcion;
                Id = MateriaActual.MateriaID;
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
