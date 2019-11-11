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
using Utils.Exceptions;

namespace UserControlsDesktop
{
    public partial class PersonaDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Persona PersonaActual { get; set; }

        public int Id { set => lbId.Text = value.ToString(); }
        public int Legajo { get => int.Parse(tbLegajo.Text); set => tbLegajo.Text = value.ToString(); }
        public string Nombre { get => tbNombre.Text; set => tbNombre.Text = value; }
        public string Apellido { get => tbApellido.Text; set => tbApellido.Text = value; }
        public string Email { get => tbEmail.Text; set => tbEmail.Text = value; }
        public string Direccion { get => tbDireccion.Text; set => tbDireccion.Text = value; }
        public Persona.Rol Tipo { get => (Persona.Rol)cbTipo.SelectedItem; set => cbTipo.SelectedItem = value; }

        public DateTime Fecha {
            get => DateTime.Parse(tbFecha.Text);
            set => tbFecha.Text = value.Date.ToString();
        }
        public string Telefono {
            get => tbTelefono.Text;
            set => tbTelefono.Text = value;
        }

        public Persona ObtenerDatos()
        {
            string role;
            if (Tipo == Persona.Rol.No_Docente)
            {
                role = "No Docente";
            }
            else if (Tipo == Persona.Rol.Docente)
            {
                role = "Docente";
            }
            else
            {
                role = "Alumno";
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        return new Persona()
                        {
                            Legajo = Legajo,
                            Nombre = Nombre,
                            Apellido = Apellido,
                            Email = Email,
                            Direccion = Direccion,
                            FechaNacimiento = Fecha,
                            Telefono = Telefono,
                            TipoPersona = Tipo,
                            Role = role
                        }; 
                    }
                case ModoForm.Modificacion:
                    {
                        PersonaActual.Legajo = Legajo;
                        PersonaActual.Nombre = Nombre;
                        PersonaActual.Apellido = Apellido;
                        PersonaActual.Email = Email;
                        PersonaActual.Direccion = Direccion;
                        PersonaActual.FechaNacimiento = Fecha;
                        PersonaActual.Telefono = Telefono;
                        PersonaActual.TipoPersona= Tipo;
                        PersonaActual.Role = role;
                        return PersonaActual;
                    }
                default: throw new InvalidInputException("Complete todos los campos obligatorios");
            }
        }

        public PersonaDetalle(ModoForm modo) : this()
        {
            Modo = modo;
            if (Modo == ModoForm.Alta)
            {
                lbId.Hide();
            }
        }

        public PersonaDetalle()
        {
            InitializeComponent();
            cbTipo.DataSource = Enum.GetValues(typeof(Persona.Rol));
        }

        public PersonaDetalle(Persona e, ModoForm modo) : this(modo)
        {
            PersonaActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                Id = e.PersonaID;
                Legajo = e.Legajo;
                Nombre = e.Nombre;
                Apellido = e.Apellido;
                Email = e.Email;
                Direccion = e.Direccion;
                Telefono = e.Telefono;
                Fecha = (DateTime) e.FechaNacimiento;
                Tipo = e.TipoPersona;
            }
            if (Modo == ModoForm.Consulta)
            {
                tbLegajo.Enabled = false;
                tbNombre.Enabled = false;
                tbApellido.Enabled = false;
                tbEmail.Enabled = false;
                tbDireccion.Enabled = false;
                tbTelefono.Enabled = false;
                tbFecha.Enabled = false;
                cbTipo.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
