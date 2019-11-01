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

namespace Escritorio
{
    public partial class AbmCursos : ManejadorForm
    {
        public AbmCursos()
        {
            InitializeComponent();
        }

        public Curso CursoActual { get; set; }


        public AbmCursos(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AbmCursos(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            CursoLogic cur = new CursoLogic();
            CursoActual = cur.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = CursoActual.CursoID.ToString();
            txtAnioCalendario.Text = CursoActual.AnioCalendario.ToString();
            txtCupo.Text = CursoActual.Cupo.ToString();
            cbMateria.SelectedItem = CursoActual.Materia; //no creo q esto ande

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
                    Curso cur = new Curso();
                    CursoActual = cur;
                }
                else
                {
                    CursoActual.CursoID = int.Parse(txtID.Text);
                }

                CursoActual.AnioCalendario = int.Parse(txtAnioCalendario.Text);
                CursoActual.Cupo = int.Parse(txtCupo.Text);
                CursoActual.Materia = (Materia) cbMateria.SelectedItem;
            }
            else if (Modo == ModoForm.Baja)
            {
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic cur = new CursoLogic();
            if (Modo == ModoForm.Alta)
            {
                cur.Add(CursoActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                cur.Update(CursoActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                cur.Delete(CursoActual.CursoID);
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtAnioCalendario.Text))
            {
                Notificar("ERROR!", "Debe ingresar el Año de calendario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtCupo.Text))
            {
                Notificar("ERROR!", "Debe ingresar el Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cbMateria.Text))
            {
                Notificar("ERROR!", "Debe seleccionar una materia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
