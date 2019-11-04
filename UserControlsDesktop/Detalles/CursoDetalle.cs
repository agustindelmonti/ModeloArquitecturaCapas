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
    public partial class CursoDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Curso CursoActual { get; set; }

        public int AnioCalendario { get => int.Parse(tbAnio.Text); set => tbAnio.Text = value.ToString(); }
        public int Cupo { get => (int) cupo.Value; set => cupo.Value = value; }
        public Especialidad Especialidad {
            get => (Especialidad) cbEspecialidad.SelectedItem;
            set => cbEspecialidad.SelectedItem = value;
        }
        public Comision Comision {
            get => (Comision) cbComision.SelectedItem;
            set => cbComision.SelectedItem = value;
        }
        public Materia Materia {
            get => (Materia) cbMateria.SelectedItem;
            set => cbMateria.SelectedItem = value;
        }
        public Plan Plan
        {
            get => (Plan)cbPlan.SelectedItem;
            set => cbPlan.SelectedItem = value;
        }


        public Curso ObtenerDatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        PersonaLogic PersonaLogic = new PersonaLogic();
                        return new Curso()
                        {
                            AnioCalendario = AnioCalendario,
                            Cupo = Cupo,
                            Materia = Materia
                        };
                    }
                case ModoForm.Modificacion:
                    {
                        CursoActual.AnioCalendario = AnioCalendario;
                        CursoActual.Cupo = Cupo;
                        CursoActual.Materia = Materia;
                        return CursoActual;
                    }
                default: throw new InvalidInputException("Complete todos los campos obligatorios");
            }
        }

        public CursoDetalle(ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic logic = new EspecialidadLogic();
            cbEspecialidad.DataSource = (List<Especialidad>) logic.GetAll();
            cbEspecialidad.DisplayMember = "Descripcion";
        }

        public CursoDetalle()
        {
            InitializeComponent();
            CursoLogic logic = new CursoLogic();
        }

        public CursoDetalle(Curso e, ModoForm modo) : this(modo)
        {
            CursoActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                AnioCalendario = CursoActual.AnioCalendario;
                Cupo = CursoActual.Cupo;
                if(CursoActual.Materia != null) Materia = CursoActual.Materia;
                if (CursoActual.Comision != null) Comision = CursoActual.Comision;
                if (Comision.Plan != null) Plan = Comision.Plan;
                if (Plan.Especialidad != null) Especialidad = Plan.Especialidad;
            }
            if (Modo == ModoForm.Consulta)
            {
                tbAnio.Enabled = false;
                cupo.Enabled = false;
                cbEspecialidad.Enabled = false;
                cbComision.Enabled = false;
                cbMateria.Enabled = false;
                cbPlan.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Si un combobox cambia , cambian los que le siguen
        private void cbEspecialidad_SelectedValueChanged(object sender, EventArgs e)
        {
            PlanLogic logic = new PlanLogic();
            cbPlan.DataSource = logic.GetAllByEspecialidad(Especialidad);
            cbPlan.DisplayMember = "Descripcion";
        }

        private void cbPlan_SelectedValueChanged(object sender, EventArgs e)
        {
            ComisionLogic ComisionLogic = new ComisionLogic();
            cbComision.DataSource = ComisionLogic.GetAllByPlan(Plan);
            cbComision.DisplayMember = "Descripcion";

            MateriaLogic MateriaLogic = new MateriaLogic();
            cbMateria.DataSource = MateriaLogic.GetAllByPlan(Plan);
            cbMateria.DisplayMember = "Descripcion";
        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanLogic logic = new PlanLogic();
            cbPlan.DataSource = logic.GetAllByEspecialidad(Especialidad);
            cbPlan.DisplayMember = "Descripcion";
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComisionLogic ComisionLogic = new ComisionLogic();
            cbComision.DataSource = ComisionLogic.GetAllByPlan(Plan);
            cbComision.DisplayMember = "Descripcion";

            MateriaLogic MateriaLogic = new MateriaLogic();
            cbMateria.DataSource = MateriaLogic.GetAllByPlan(Plan);
            cbMateria.DisplayMember = "Descripcion";
        }
    }
}
