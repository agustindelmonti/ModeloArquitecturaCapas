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
using Microsoft.Reporting.WinForms;

namespace Escritorio
{
    public partial class ReporteCursos : Form
    {
        public ReporteCursos()
        {
            InitializeComponent();
            
        }

        private void ReporteCursos_Load(object sender, EventArgs e)
        {
            CursoLogic cur = new CursoLogic();
            CursoBindingSource.DataSource = cur.GetAll();
            this.informeCurso.RefreshReport();
        }

    }
}
