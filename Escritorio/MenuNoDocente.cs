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
    public partial class MenuNoDocente : Form
    {
        public MenuNoDocente()
        {
            InitializeComponent();
        }


        private void Usuarios_Click(object sender, EventArgs e)
        {
            //Usuario u = new Usuario();
            //u.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            //Escritorio.Plan p = new Escritorio.Plan();
            //p.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            //Escritorio.Especialidad esp = new Escritorio.Especialidad();
            //esp.ShowDialog();
        }
    }
}
