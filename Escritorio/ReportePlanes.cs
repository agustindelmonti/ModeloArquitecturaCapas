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

namespace Escritorio
{
    public partial class ReportePlanes : UserControl
    {
        public ReportePlanes()
        {
            InitializeComponent();
        }

        private void ReportePlanes_Load(object sender, EventArgs e)
        {
                PlanLogic plan = new PlanLogic();
                PlanBindingSource.DataSource = plan.GetAll();
                this.informePlanes.RefreshReport();
        }
    }
}
