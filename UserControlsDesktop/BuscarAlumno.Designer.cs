namespace UserControlsDesktop
{
    partial class BuscarAlumno
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombreApellido = new System.Windows.Forms.Label();
            this.tbLegajo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbNombreApellido
            // 
            this.lbNombreApellido.AutoSize = true;
            this.lbNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNombreApellido.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbNombreApellido.Location = new System.Drawing.Point(338, 16);
            this.lbNombreApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreApellido.Name = "lbNombreApellido";
            this.lbNombreApellido.Size = new System.Drawing.Size(180, 20);
            this.lbNombreApellido.TabIndex = 19;
            this.lbNombreApellido.Text = "<<Nombre Apellido>";
            // 
            // tbLegajo
            // 
            this.tbLegajo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbLegajo.Location = new System.Drawing.Point(98, 16);
            this.tbLegajo.Margin = new System.Windows.Forms.Padding(4);
            this.tbLegajo.Mask = "00000";
            this.tbLegajo.Name = "tbLegajo";
            this.tbLegajo.Size = new System.Drawing.Size(107, 22);
            this.tbLegajo.TabIndex = 17;
            this.tbLegajo.ValidatingType = typeof(System.DateTime);
            this.tbLegajo.TextChanged += new System.EventHandler(this.tbLegajo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Legajo *";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(232, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 495);
            this.panel1.TabIndex = 22;
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbNombreApellido);
            this.Controls.Add(this.tbLegajo);
            this.Controls.Add(this.label5);
            this.Name = "BuscarAlumno";
            this.Size = new System.Drawing.Size(969, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreApellido;
        private System.Windows.Forms.MaskedTextBox tbLegajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
    }
}
