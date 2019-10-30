namespace Escritorio
{
    partial class MenuDocente
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
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnEspecialidades, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPlanes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEspecialidades.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEspecialidades.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.btnEspecialidades.Location = new System.Drawing.Point(136, 245);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(227, 49);
            this.btnEspecialidades.TabIndex = 2;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlanes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlanes.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.btnPlanes.Location = new System.Drawing.Point(136, 168);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(227, 49);
            this.btnPlanes.TabIndex = 1;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsuarios.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(136, 91);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(227, 49);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(501, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnUsuarios;
    }
}