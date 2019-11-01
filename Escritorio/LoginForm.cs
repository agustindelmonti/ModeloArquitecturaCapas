using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities;

namespace Escritorio
{
    public partial class LoginForm : Form
    {
        public Usuario UsuarioAutenticado { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            lblMensaje.Hide();
        }

        private void btnInciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usr = ObtenerUsuario();
            UsuarioLogic uLogic = new UsuarioLogic();
            
            try
            {
                lblMensaje.ForeColor = Color.CadetBlue;
                lblMensaje.Text = "Cargando. Por favor espere.";
                lblMensaje.Show();

                UsuarioAutenticado = uLogic.AuthCredentials(usr);
                Close();

            }
            catch (UserAuthenticationException error)
            {
                lblMensaje.Text = error.Message;
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Show();
            }
        }

        private Usuario ObtenerUsuario()
        {
            return new Usuario() { NombreUsuario = tbUsuario.Text, Clave = tbClave.Text};
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, this.Bounds);
        }
    }
}
