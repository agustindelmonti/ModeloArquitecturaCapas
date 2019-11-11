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
using BusinessLogic;

namespace UserControlsDesktop
{
    public partial class Perfil : UserControl
    {
        public Perfil(Usuario u)
        {
            

            InitializeComponent();
            lblApellido.Text = u.Persona.Apellido;
            lblNombre.Text = u.Persona.Nombre;
            lblDireccion.Text = u.Persona.Direccion;
            lblLegajo.Text = u.Persona.Legajo.ToString();
            lblEmail.Text = u.Persona.Email;
            lblTelefono.Text = u.Persona.Telefono;
        }
    }
}
