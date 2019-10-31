namespace Escritorio
{
    partial class AbmUsuarios
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
            this.lID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lClave = new System.Windows.Forms.Label();
            this.lConfirm = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.chkCambiaClave = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lClave, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lConfirm, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtConfirmarClave, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkHabilitado, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkCambiaClave, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPersona, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(4, 0);
            this.lID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(21, 17);
            this.lID.TabIndex = 2;
            this.lID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 4);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(738, 240);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(431, 240);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 28);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(4, 59);
            this.lUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(57, 17);
            this.lUsuario.TabIndex = 7;
            this.lUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(79, 63);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(319, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(4, 118);
            this.lClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(43, 17);
            this.lClave.TabIndex = 5;
            this.lClave.Text = "Clave";
            // 
            // lConfirm
            // 
            this.lConfirm.AutoSize = true;
            this.lConfirm.Location = new System.Drawing.Point(431, 118);
            this.lConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConfirm.Name = "lConfirm";
            this.lConfirm.Size = new System.Drawing.Size(73, 34);
            this.lConfirm.TabIndex = 8;
            this.lConfirm.Text = "Confirmar Clave";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmarClave.Location = new System.Drawing.Point(518, 122);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '●';
            this.txtConfirmarClave.Size = new System.Drawing.Size(320, 22);
            this.txtConfirmarClave.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClave.Location = new System.Drawing.Point(79, 122);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '●';
            this.txtClave.Size = new System.Drawing.Size(319, 22);
            this.txtClave.TabIndex = 2;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(79, 181);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(93, 21);
            this.chkHabilitado.TabIndex = 5;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // chkCambiaClave
            // 
            this.chkCambiaClave.AutoSize = true;
            this.chkCambiaClave.Location = new System.Drawing.Point(517, 180);
            this.chkCambiaClave.Name = "chkCambiaClave";
            this.chkCambiaClave.Size = new System.Drawing.Size(114, 21);
            this.chkCambiaClave.TabIndex = 6;
            this.chkCambiaClave.Text = "Cambia clave";
            this.chkCambiaClave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Persona";
            // 
            // cbPersona
            // 
            this.cbPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Location = new System.Drawing.Point(517, 3);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(322, 24);
            this.cbPersona.TabIndex = 2;
            // 
            // AbmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AbmUsuarios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Usuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lConfirm;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox chkCambiaClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersona;
    }
}