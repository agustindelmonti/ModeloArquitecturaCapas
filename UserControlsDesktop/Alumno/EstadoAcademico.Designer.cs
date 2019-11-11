namespace UserControlsDesktop.Alumno {
    partial class EstadoAcademico {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstadoAcademico = new System.Windows.Forms.DataGridView();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAcademico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstadoAcademico
            // 
            this.dgvEstadoAcademico.AllowUserToAddRows = false;
            this.dgvEstadoAcademico.AllowUserToDeleteRows = false;
            this.dgvEstadoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoAcademico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Año,
            this.Materia,
            this.Condicion,
            this.Nota,
            this.Comision,
            this.AñoAcademico,
            this.Plan});
            this.dgvEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadoAcademico.Location = new System.Drawing.Point(0, 0);
            this.dgvEstadoAcademico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEstadoAcademico.Name = "dgvEstadoAcademico";
            this.dgvEstadoAcademico.ReadOnly = true;
            this.dgvEstadoAcademico.RowHeadersVisible = false;
            this.dgvEstadoAcademico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEstadoAcademico.Size = new System.Drawing.Size(1068, 642);
            this.dgvEstadoAcademico.TabIndex = 0;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "AñoEspecialidad";
            this.Año.HeaderText = "Año Especialidad";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 130;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "NombreMateria";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 240;
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            this.Condicion.Width = 150;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "Nota";
            dataGridViewCellStyle1.NullValue = "Sin Calificar";
            this.Nota.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "NumeroComision";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            this.Comision.Width = 120;
            // 
            // AñoAcademico
            // 
            this.AñoAcademico.DataPropertyName = "AñoCalendario";
            this.AñoAcademico.HeaderText = "Año Calendario";
            this.AñoAcademico.Name = "AñoAcademico";
            this.AñoAcademico.ReadOnly = true;
            this.AñoAcademico.Width = 130;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "Plan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            this.Plan.Width = 180;
            // 
            // EstadoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEstadoAcademico);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EstadoAcademico";
            this.Size = new System.Drawing.Size(1068, 642);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAcademico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadoAcademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoAcademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
    }
}
