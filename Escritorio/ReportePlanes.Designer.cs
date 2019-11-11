namespace Escritorio
{
    partial class ReportePlanes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informePlanes = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanBindingSource
            // 
            this.PlanBindingSource.DataSource = typeof(Entities.Plan);
            // 
            // informePlanes
            // 
            this.informePlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPlanes";
            reportDataSource1.Value = this.PlanBindingSource;
            this.informePlanes.LocalReport.DataSources.Add(reportDataSource1);
            this.informePlanes.LocalReport.ReportEmbeddedResource = "Escritorio.InformePlanes.rdlc";
            this.informePlanes.Location = new System.Drawing.Point(0, 0);
            this.informePlanes.Name = "informePlanes";
            this.informePlanes.ServerReport.BearerToken = null;
            this.informePlanes.Size = new System.Drawing.Size(1040, 555);
            this.informePlanes.TabIndex = 0;
            this.informePlanes.Load += new System.EventHandler(this.ReportePlanes_Load);
            // 
            // ReportePlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.informePlanes);
            this.Name = "ReportePlanes";
            this.Size = new System.Drawing.Size(1040, 555);
            this.Load += new System.EventHandler(this.ReportePlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informePlanes;
        private System.Windows.Forms.BindingSource PlanBindingSource;
    }
}