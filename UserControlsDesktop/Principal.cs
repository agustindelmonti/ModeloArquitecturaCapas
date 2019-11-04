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

namespace UserControlsDesktop
{
    public partial class Principal : UserControl
    {

        public Principal(Usuario u)
        {
            InitializeComponent();
            lbUser.Text = u.Persona.Nombre;
        }
    }
}
