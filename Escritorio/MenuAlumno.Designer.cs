namespace Escritorio
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
            this.especialidadDetalle1 = new UserControlsDesktop.EspecialidadDetalle();
            this.SuspendLayout();
            // 
            // especialidadDetalle1
            // 
            this.especialidadDetalle1.EspecialidadActual = null;
            this.especialidadDetalle1.Location = new System.Drawing.Point(388, 3);
            this.especialidadDetalle1.Name = "especialidadDetalle1";
            this.especialidadDetalle1.Size = new System.Drawing.Size(237, 450);
            this.especialidadDetalle1.TabIndex = 0;
            // 
            // MenuAlumno
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(628, 452);
            this.Controls.Add(this.especialidadDetalle1);
            this.MaximizeBox = false;
            this.Name = "MenuAlumno";
            this.Text = "Academia";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlsDesktop.EspecialidadDetalle especialidadDetalle1;
    }
}