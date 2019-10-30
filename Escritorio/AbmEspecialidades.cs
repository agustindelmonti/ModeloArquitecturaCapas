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
    public partial class AbmEspecialidades : ManejadorForm
    {

        public AbmEspecialidades()
        {
            InitializeComponent();
        }

        public Especialidad EspecialidadActual { get; set; }




        public AbmEspecialidades(ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public AbmEspecialidades(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic es = new EspecialidadLogic();
            this.EspecialidadActual = es.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.EspecialidadID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

            if (this.Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }

            if (this.Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
        }


        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {

                if (this.Modo == ModoForm.Alta)
                {
                    Especialidad esp = new Especialidad();
                    this.EspecialidadActual = esp;
                    this.EspecialidadActual.State = BusinessEntity.States.New;
                }
                else
                {
                    //int id = 0;
                    //if (!int.TryParse("asdasd", out id))
                    //{
                    //    MessageBox.Show("Debe ingrear un int");
                    //}
                    //Convert.ToInt32("1244");
                    this.EspecialidadActual.EspecialidadID = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                }

                this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
            }
            if (this.Modo == ModoForm.Consulta)
            {
                this.EspecialidadActual.State = BusinessEntity.States.Unmodified;
            }
            else if (this.Modo == ModoForm.Baja)
            {
                this.EspecialidadActual.State = BusinessEntity.States.Deleted;

            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic es = new EspecialidadLogic();
            if (this.Modo == ModoForm.Alta)
            {
                es.Add(this.EspecialidadActual);
            }
            else if (this.Modo == ModoForm.Modificacion)
            {
                es.Update(this.EspecialidadActual);

            }
            else if (this.Modo == ModoForm.Consulta)
            {
            }
            else if (this.Modo == ModoForm.Baja)
            {
                es.Remove(this.EspecialidadActual.EspecialidadID);
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
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
