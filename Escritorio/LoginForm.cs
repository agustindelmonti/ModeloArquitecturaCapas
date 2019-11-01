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
        }

        private void btnInciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usr = ObtenerUsuario();
            UsuarioLogic uLogic = new UsuarioLogic();
            
            try
            {
                UsuarioAutenticado = uLogic.AuthCredentials(usr);
                Close();

            }
            catch (UserAuthenticationException error)
            {
                MessageBox.Show(error.Message);
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
