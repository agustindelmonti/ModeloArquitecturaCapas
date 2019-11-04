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
    public partial class UsuarioDetalle : Detalle
    {
        //Propriedades que me permiten cambiar el estado del UserControl desde afuera
        public Usuario UsuarioActual { get; set; }

        public int Legajo { get => int.Parse(tbLegajo.Text); set => tbLegajo.Text = value.ToString(); }
        public string Nombre { get => tbNombre.Text; set => tbNombre.Text = value; }
        public string Clave { get => tbClave.Text; set => tbClave.Text = value; }
        public bool Habilitado{ get => chkHabilitado.Checked; set => chkHabilitado.Checked = value; }


        public Usuario ObtenerDatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        PersonaLogic PersonaLogic = new PersonaLogic();
                        return new Usuario()
                        {
                            Persona = PersonaLogic.GetByLegajo(Legajo),
                            NombreUsuario = Nombre,
                            Clave = Clave,
                            Habilitado = Habilitado
                        };
                    }
                case ModoForm.Modificacion:
                    {
                        UsuarioActual.NombreUsuario = Nombre;
                        UsuarioActual.Clave = Clave;
                        UsuarioActual.Habilitado = Habilitado;
                        return UsuarioActual;
                    }
                default: throw new InvalidInputException("Complete todos los campos obligatorios");
            }
        }

        public UsuarioDetalle(ModoForm modo) : this()
        {
            Modo = modo;
            lbNombreApellido.Text = "";
        }

        public UsuarioDetalle()
        {
            InitializeComponent();
            UsuarioLogic logic = new UsuarioLogic();
        }

        public UsuarioDetalle(Usuario e, ModoForm modo) : this(modo)
        {
            UsuarioActual = e;

            if (Modo == ModoForm.Consulta || Modo == ModoForm.Modificacion)
            {
                tbLegajo.Enabled = false;
                Nombre = UsuarioActual.NombreUsuario;
                Legajo = UsuarioActual.Persona.Legajo;
            }
            if (Modo == ModoForm.Consulta)
            {
                tbNombre.Enabled = false;
                tbClave.Enabled = false;
                chkHabilitado.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbLegajo_TextChanged(object sender, EventArgs e)
        {
            //Busco la persona al ingresar el legajo
            PersonaLogic PersonaLogic = new PersonaLogic();
            try
            {
                Persona p = PersonaLogic.GetByLegajo(Legajo);

                if (p == null)
                {
                    lbNombreApellido.ForeColor = Color.Orange;
                    lbNombreApellido.Text = "No se encontro persona";
                }
                else
                {
                    lbNombreApellido.ForeColor = Color.Teal;
                    lbNombreApellido.Text = p.Apellido +" "+ p.Nombre;
                }
            }
            catch(Exception error)
            {

            }
        }
    }
}
