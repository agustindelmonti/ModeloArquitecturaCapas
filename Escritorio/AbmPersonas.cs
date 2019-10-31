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
using System.Text.RegularExpressions;

//en cuanto a inscripciones si es alumno y cursos del docente.. no se eso si hacerlo desde aca o desde las otras clases
//revisar que ande
namespace Escritorio
{
    public partial class AbmPersonas : ManejadorForm
    {
        public AbmPersonas()
        {
            InitializeComponent();
            cbTipoPersona.DataSource = Enum.GetValues(typeof(Persona.Rol));
        }


        public Persona PersonaActual { get; set; }

        public AbmPersonas(ModoForm modo) : this()
        {
            this.Modo = modo;
        }


        public AbmPersonas(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PersonaLogic p = new PersonaLogic();
            PersonaActual = p.Find(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtID.Text = PersonaActual.PersonaID.ToString();
            cbTipoPersona.SelectedItem = PersonaActual.TipoPersona;//no creo q ande esto
            txtNombre.Text = PersonaActual.Nombre;
            txtApellido.Text = PersonaActual.Apellido;
            txtDireccion.Text = PersonaActual.Direccion;
            txtEmail.Text = PersonaActual.Email;
            txtTelefono.Text = PersonaActual.Telefono;
            txtLegajo.Text = PersonaActual.Legajo.ToString();
            //creo que la fecha no se puede asignar

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
                    Persona per = new Persona();
                    PersonaActual = per;
                }
                else
                {
                    PersonaActual.PersonaID = int.Parse(txtID.Text);
                }

                PersonaActual.TipoPersona =(Persona.Rol) cbTipoPersona.SelectedItem;
                PersonaActual.Nombre = txtNombre.Text;
                PersonaActual.Apellido = txtApellido.Text;
                PersonaActual.Direccion = txtDireccion.Text;
                PersonaActual.Email = txtEmail.Text;
                PersonaActual.Telefono = txtTelefono.Text;
                PersonaActual.Legajo = int.Parse(txtLegajo.Text);
                PersonaActual.FechaNacimiento = dtFechaNac.Value;
            }
            else if (Modo == ModoForm.Baja)
            {
                PersonaActual.State = BusinessEntity.States.Deleted;
            }
        }


        public override void GuardarCambios()
        {
            MapearADatos();
            PersonaLogic p = new PersonaLogic();
            if (Modo == ModoForm.Alta)
            {
                p.Add(PersonaActual);
            }
            else if (Modo == ModoForm.Modificacion)
            {
                p.Update(PersonaActual);

            }
            else if (Modo == ModoForm.Baja)
            {
                p.Delete(PersonaActual.PersonaID);
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                Notificar("ERROR!", "Debe ingresar un Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                Notificar("ERROR!", "Debe ingresar un Apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                Notificar("ERROR!", "Debe ingresar una Direccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Notificar("ERROR!", "Debe ingresar el Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!Regex.IsMatch(this.txtEmail.Text, expresion))
            {
                Notificar("ERROR!", "El Email no es valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                Notificar("ERROR!", "Debe ingresar un Telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtLegajo.Text))
            {
                Notificar("ERROR!", "Debe ingresar un Legajo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtFechaNac.Value == DateTime.Today)
            {
                Notificar("ERROR!", "Debe ingresar una fecha de nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cbTipoPersona.Text))
            {
                Notificar("ERROR!", "Debe seleccionar el tipo de persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
