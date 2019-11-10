namespace UserControlsDesktop.Alumno {
    partial class MisCursos {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvMisCursos = new System.Windows.Forms.DataGridView();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMisCursos
            // 
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMateria,
            this.NroComision});
            this.dgvMisCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMisCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.Size = new System.Drawing.Size(632, 330);
            this.dgvMisCursos.TabIndex = 0;
            // 
            // NombreMateria
            // 
            this.NombreMateria.DataPropertyName = "NombreMateria";
            this.NombreMateria.HeaderText = "Materia";
            this.NombreMateria.Name = "NombreMateria";
            // 
            // NroComision
            // 
            this.NroComision.DataPropertyName = "NroComision";
            this.NroComision.HeaderText = "Nro Comision";
            this.NroComision.Name = "NroComision";
            // 
            // MisCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMisCursos);
            this.Name = "MisCursos";
            this.Size = new System.Drawing.Size(632, 330);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMisCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroComision;
    }
}
