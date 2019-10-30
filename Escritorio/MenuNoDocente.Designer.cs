namespace Escritorio
{
    partial class MenuNoDocente
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
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAlumnos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProfesores, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMaterias, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPlanes, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEspecialidades, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnComisiones, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCursos, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEspecialidades.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEspecialidades.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnEspecialidades.Location = new System.Drawing.Point(263, 71);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(186, 49);
            this.btnEspecialidades.TabIndex = 2;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = false;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlanes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlanes.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnPlanes.Location = new System.Drawing.Point(263, 135);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(186, 49);
            this.btnPlanes.TabIndex = 1;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsuarios.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Location = new System.Drawing.Point(51, 71);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(186, 49);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaterias.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMaterias.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnMaterias.Location = new System.Drawing.Point(263, 199);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(186, 49);
            this.btnMaterias.TabIndex = 3;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlumnos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAlumnos.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnAlumnos.Location = new System.Drawing.Point(51, 135);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(186, 49);
            this.btnAlumnos.TabIndex = 4;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfesores.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProfesores.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnProfesores.Location = new System.Drawing.Point(51, 199);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(186, 49);
            this.btnProfesores.TabIndex = 5;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            // 
            // btnComisiones
            // 
            this.btnComisiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComisiones.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnComisiones.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnComisiones.Location = new System.Drawing.Point(263, 263);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.Size = new System.Drawing.Size(186, 49);
            this.btnComisiones.TabIndex = 6;
            this.btnComisiones.Text = "Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = false;
            // 
            // btnCursos
            // 
            this.btnCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCursos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCursos.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            this.btnCursos.Location = new System.Drawing.Point(51, 263);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(186, 49);
            this.btnCursos.TabIndex = 7;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            // 
            // MenuNoDocente
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(501, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "MenuNoDocente";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Button btnCursos;
    }
}