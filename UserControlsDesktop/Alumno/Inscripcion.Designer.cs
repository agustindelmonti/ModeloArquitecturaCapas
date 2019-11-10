namespace UserControlsDesktop.Alumno {
    partial class Inscripcion {
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
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auxiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ayudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscribir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.AllowUserToAddRows = false;
            this.dgvInscripcion.AllowUserToDeleteRows = false;
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.NroComision,
            this.Titular,
            this.Auxiliar,
            this.Ayudante,
            this.Inscribir});
            this.dgvInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripcion.Location = new System.Drawing.Point(0, 0);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.ReadOnly = true;
            this.dgvInscripcion.Size = new System.Drawing.Size(651, 349);
            this.dgvInscripcion.TabIndex = 0;
            this.dgvInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcion_CellContentClick);
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "NombreMateria";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // NroComision
            // 
            this.NroComision.DataPropertyName = "NroComision";
            this.NroComision.HeaderText = "Número de Comisión";
            this.NroComision.Name = "NroComision";
            this.NroComision.ReadOnly = true;
            // 
            // Titular
            // 
            this.Titular.DataPropertyName = "Titular";
            this.Titular.HeaderText = "Titular";
            this.Titular.Name = "Titular";
            this.Titular.ReadOnly = true;
            // 
            // Auxiliar
            // 
            this.Auxiliar.DataPropertyName = "Auxiliar";
            this.Auxiliar.HeaderText = "Auxiliar";
            this.Auxiliar.Name = "Auxiliar";
            this.Auxiliar.ReadOnly = true;
            // 
            // Ayudante
            // 
            this.Ayudante.DataPropertyName = "Ayudante";
            this.Ayudante.HeaderText = "Ayudante";
            this.Ayudante.Name = "Ayudante";
            this.Ayudante.ReadOnly = true;
            // 
            // Inscribir
            // 
            this.Inscribir.HeaderText = "Inscribir";
            this.Inscribir.Name = "Inscribir";
            this.Inscribir.ReadOnly = true;
            this.Inscribir.Text = "Inscribir";
            this.Inscribir.UseColumnTextForButtonValue = true;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInscripcion);
            this.Name = "Inscripcion";
            this.Size = new System.Drawing.Size(651, 349);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ayudante;
        private System.Windows.Forms.DataGridViewButtonColumn Inscribir;
    }
}
