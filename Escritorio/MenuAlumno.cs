using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class MenuAlumno : Form
    {
        public MenuAlumno()
        {
            InitializeComponent();
        }


        private void Usuarios_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Plan p = new Plan();
            p.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            UI.Desktop.Especialidad esp = new UI.Desktop.Especialidad();
            esp.ShowDialog();
        }
    }
}
