namespace Escritorio
{
    partial class ListaMateriasPermitidas
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
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.tlInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.tlInscripciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Comision});
            this.tlInscripciones.SetColumnSpan(this.dgvInscripcion, 2);
            this.dgvInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripcion.Location = new System.Drawing.Point(3, 3);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.RowTemplate.Height = 24;
            this.dgvInscripcion.Size = new System.Drawing.Size(963, 509);
            this.dgvInscripcion.TabIndex = 0;
            // 
            // tlInscripciones
            // 
            this.tlInscripciones.ColumnCount = 2;
            this.tlInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlInscripciones.Controls.Add(this.dgvInscripcion, 0, 0);
            this.tlInscripciones.Controls.Add(this.btnInscribirse, 1, 1);
            this.tlInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlInscripciones.Name = "tlInscripciones";
            this.tlInscripciones.RowCount = 2;
            this.tlInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlInscripciones.Size = new System.Drawing.Size(969, 555);
            this.tlInscripciones.TabIndex = 1;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInscribirse.Location = new System.Drawing.Point(873, 518);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(93, 29);
            this.btnInscribirse.TabIndex = 1;
            this.btnInscribirse.Text = "Inscibirse";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "MateriaID";
            this.Materia.HeaderText = "ID Materia";
            this.Materia.Name = "Materia";
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "ComisionID";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            // 
            // ListaMateriasPermitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlInscripciones);
            this.Name = "ListaMateriasPermitidas";
            this.Size = new System.Drawing.Size(969, 555);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.tlInscripciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.TableLayoutPanel tlInscripciones;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
    }
}