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
using UserControlsDesktop.Alumno;

namespace UserControlsDesktop
{
    public partial class BuscarAlumno : UserControl
    {
        public int Legajo { get => int.Parse(tbLegajo.Text); set => tbLegajo.Text = value.ToString(); }
        public Persona Persona { get; set; }
        PersonaLogic PersonaLogic = new PersonaLogic();

        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void tbLegajo_TextChanged(object sender, EventArgs e)
        {
            //Busco la persona al ingresar el legajo
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
                    lbNombreApellido.Text = p.Apellido + " " + p.Nombre;
                }
            }
            catch (Exception error)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Persona = PersonaLogic.GetByLegajo(Legajo);
            if (Persona != null)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new Inscripcion(Persona.Usuario));
            }

        }
    }
}
