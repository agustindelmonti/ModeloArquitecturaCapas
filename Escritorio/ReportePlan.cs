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
    public partial class ReportePlan : UserControl
    {
        public ReportePlan()
        {
            InitializeComponent();
        }

        private void ReportePlan_Load(object sender, EventArgs e)
        {
            PlanLogic pla = new PlanLogic();
            PlanBindingSource.DataSource = pla.GetAll();
            this.reportViewer1.RefreshReport();
        }
    }
}
