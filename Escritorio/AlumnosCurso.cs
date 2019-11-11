using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlsDesktop.Listados;

namespace Escritorio {
    public partial class AlumnosCurso : Form {
        public AlumnosCurso(int cursoID, int docenteID) {
            InitializeComponent();

            panel1.Controls.Add(new ListadoAlumnosCurso(cursoID, docenteID));
        }
    }
}
