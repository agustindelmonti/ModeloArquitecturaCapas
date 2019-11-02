namespace UserControlsDesktop
{
    partial class Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tsEspecialidades = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.tsEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsEspecialidades);
            this.panel1.Controls.Add(this.bntCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 450);
            this.panel1.TabIndex = 2;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCancelar.Location = new System.Drawing.Point(143, 414);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(81, 24);
            this.bntCancelar.TabIndex = 4;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(23, 414);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(77, 24);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tsEspecialidades
            // 
            this.tsEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidades.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tsEspecialidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.btnEditar,
            this.btnBorrar});
            this.tsEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tsEspecialidades.Name = "tsEspecialidades";
            this.tsEspecialidades.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsEspecialidades.Size = new System.Drawing.Size(99, 32);
            this.tsEspecialidades.TabIndex = 5;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 29);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(29, 29);
            this.btnEditar.Text = "toolStripButton1";
            this.btnEditar.ToolTipText = "Editar";
            // 
            // btnBorrar
            // 
            this.btnBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(29, 29);
            this.btnBorrar.Text = "toolStripButton2";
            this.btnBorrar.ToolTipText = "Borrar";
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Detalle";
            this.Size = new System.Drawing.Size(237, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsEspecialidades.ResumeLayout(false);
            this.tsEspecialidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}
