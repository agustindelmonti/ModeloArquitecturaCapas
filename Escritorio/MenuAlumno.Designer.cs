﻿namespace Escritorio
{
    partial class MenuAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAlumno));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esatdoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.esatdoAcademicoToolStripMenuItem,
            this.inscribirseToolStripMenuItem,
            this.actualizarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.principalToolStripMenuItem.Text = "Principal";
            this.principalToolStripMenuItem.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // esatdoAcademicoToolStripMenuItem
            // 
            this.esatdoAcademicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoAcademicoToolStripMenuItem,
            this.misCursosToolStripMenuItem});
            this.esatdoAcademicoToolStripMenuItem.Name = "esatdoAcademicoToolStripMenuItem";
            this.esatdoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.esatdoAcademicoToolStripMenuItem.Text = "Consultar";
            // 
            // estadoAcademicoToolStripMenuItem
            // 
            this.estadoAcademicoToolStripMenuItem.Name = "estadoAcademicoToolStripMenuItem";
            this.estadoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.estadoAcademicoToolStripMenuItem.Text = "Estado Academico";
            this.estadoAcademicoToolStripMenuItem.Click += new System.EventHandler(this.estadoAcademicoToolStripMenuItem_Click);
            // 
            // misCursosToolStripMenuItem
            // 
            this.misCursosToolStripMenuItem.Name = "misCursosToolStripMenuItem";
            this.misCursosToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.misCursosToolStripMenuItem.Text = "Mis Cursos";
            this.misCursosToolStripMenuItem.Click += new System.EventHandler(this.misCursosToolStripMenuItem_Click);
            // 
            // inscribirseToolStripMenuItem
            // 
            this.inscribirseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaToolStripMenuItem});
            this.inscribirseToolStripMenuItem.Name = "inscribirseToolStripMenuItem";
            this.inscribirseToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.inscribirseToolStripMenuItem.Text = "Inscribirse";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.materiaToolStripMenuItem.Text = "Cursado";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.actualizarDatosToolStripMenuItem.Text = "Perfil";
            this.actualizarDatosToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 448);
            this.panel1.TabIndex = 1;
            // 
            // MenuAlumno
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem esatdoAcademicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoAcademicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}