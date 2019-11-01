namespace Escritorio
{
    partial class AbmComisiones
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lId = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bntCancelar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAño, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbPlan, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(3, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(21, 17);
            this.lId.TabIndex = 0;
            this.lId.Text = "ID";
            this.lId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(3, 40);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lDescripcion.TabIndex = 1;
            this.lDescripcion.Text = "Descripcion";
            // 
            // bntCancelar
            // 
            this.bntCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntCancelar.Location = new System.Drawing.Point(351, 169);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(94, 30);
            this.bntCancelar.TabIndex = 3;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(159, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(260, 22);
            this.txtID.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(78, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Location = new System.Drawing.Point(159, 43);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(286, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtAño
            // 
            this.txtAño.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAño.Location = new System.Drawing.Point(159, 83);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(286, 22);
            this.txtAño.TabIndex = 6;
            // 
            // cbPlan
            // 
            this.cbPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(159, 123);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(286, 24);
            this.cbPlan.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Año de cursado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plan";
            // 
            // AbmComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 202);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AbmComisiones";
            this.Text = "ABM Comisiones";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}