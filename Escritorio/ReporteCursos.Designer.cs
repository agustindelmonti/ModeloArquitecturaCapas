﻿namespace Escritorio
{
    partial class ReporteCursos
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
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informeCurso = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataSource = typeof(Entities.Curso);
            // 
            // informeCurso
            // 
            this.informeCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCurso";
            reportDataSource1.Value = this.CursoBindingSource;
            this.informeCurso.LocalReport.DataSources.Add(reportDataSource1);
            this.informeCurso.LocalReport.ReportEmbeddedResource = "Escritorio.InformeCursos.rdlc";
            this.informeCurso.Location = new System.Drawing.Point(0, 0);
            this.informeCurso.Name = "informeCurso";
            this.informeCurso.ServerReport.BearerToken = null;
            this.informeCurso.Size = new System.Drawing.Size(800, 450);
            this.informeCurso.TabIndex = 0;
            // 
            // ReporteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informeCurso);
            this.Name = "ReporteCursos";
            this.Text = "ReporteCursos";
            this.Load += new System.EventHandler(this.ReporteCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer informeCurso;
        private System.Windows.Forms.BindingSource CursoBindingSource;
    }
}