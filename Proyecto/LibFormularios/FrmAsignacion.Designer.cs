
namespace LibFormularios
{
    partial class FrmAsignacion
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
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.txt_CodDocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvTutorias = new System.Windows.Forms.DataGridView();
            this.CodEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarreraProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPasar2 = new System.Windows.Forms.Button();
            this.lb_Semestre = new System.Windows.Forms.Label();
            this.txt_Semestre = new System.Windows.Forms.TextBox();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerTutores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(26, 84);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(359, 344);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // txt_CodDocente
            // 
            this.txt_CodDocente.Location = new System.Drawing.Point(174, 21);
            this.txt_CodDocente.Name = "txt_CodDocente";
            this.txt_CodDocente.Size = new System.Drawing.Size(100, 20);
            this.txt_CodDocente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CodDocente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estudiantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estudiantes en tutorias";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(68)))));
            this.btnConfirmar.Location = new System.Drawing.Point(745, 450);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(81, 28);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // dgvTutorias
            // 
            this.dgvTutorias.AllowUserToAddRows = false;
            this.dgvTutorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTutorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEstudiante,
            this.Nombres,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.CarreraProfesional,
            this.Condicion});
            this.dgvTutorias.Location = new System.Drawing.Point(493, 84);
            this.dgvTutorias.Name = "dgvTutorias";
            this.dgvTutorias.Size = new System.Drawing.Size(359, 344);
            this.dgvTutorias.TabIndex = 0;
            // 
            // CodEstudiante
            // 
            this.CodEstudiante.HeaderText = "CodEstudiante";
            this.CodEstudiante.Name = "CodEstudiante";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "ApellidoPaterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "ApellidoMaterno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            // 
            // CarreraProfesional
            // 
            this.CarreraProfesional.HeaderText = "CarreraProfesional";
            this.CarreraProfesional.Name = "CarreraProfesional";
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            // 
            // btnPasar2
            // 
            this.btnPasar2.Location = new System.Drawing.Point(407, 238);
            this.btnPasar2.Name = "btnPasar2";
            this.btnPasar2.Size = new System.Drawing.Size(58, 23);
            this.btnPasar2.TabIndex = 3;
            this.btnPasar2.Text = "-->";
            this.btnPasar2.UseVisualStyleBackColor = true;
            this.btnPasar2.Click += new System.EventHandler(this.BtnPasar2_Click_1);
            // 
            // lb_Semestre
            // 
            this.lb_Semestre.AutoSize = true;
            this.lb_Semestre.Location = new System.Drawing.Point(335, 24);
            this.lb_Semestre.Name = "lb_Semestre";
            this.lb_Semestre.Size = new System.Drawing.Size(51, 13);
            this.lb_Semestre.TabIndex = 4;
            this.lb_Semestre.Text = "Semestre";
            // 
            // txt_Semestre
            // 
            this.txt_Semestre.Location = new System.Drawing.Point(407, 21);
            this.txt_Semestre.Name = "txt_Semestre";
            this.txt_Semestre.Size = new System.Drawing.Size(100, 20);
            this.txt_Semestre.TabIndex = 5;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(707, 18);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_Fecha.TabIndex = 6;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(607, 21);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lb_Fecha.TabIndex = 7;
            this.lb_Fecha.Text = "Fecha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(15)))), ((int)(((byte)(48)))));
            this.btnCancelar.Location = new System.Drawing.Point(638, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnVerTutores
            // 
            this.btnVerTutores.Location = new System.Drawing.Point(37, 453);
            this.btnVerTutores.Name = "btnVerTutores";
            this.btnVerTutores.Size = new System.Drawing.Size(121, 23);
            this.btnVerTutores.TabIndex = 8;
            this.btnVerTutores.Text = "Ver lista de tutores";
            this.btnVerTutores.UseVisualStyleBackColor = true;
            this.btnVerTutores.Click += new System.EventHandler(this.btnVerTutores_Click);
            // 
            // FrmAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.btnVerTutores);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.txt_Semestre);
            this.Controls.Add(this.lb_Semestre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPasar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CodDocente);
            this.Controls.Add(this.dgvTutorias);
            this.Controls.Add(this.dgvEstudiantes);
            this.Name = "FrmAsignacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox txt_CodDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvTutorias;
        private System.Windows.Forms.Button btnPasar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarreraProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.Label lb_Semestre;
        private System.Windows.Forms.TextBox txt_Semestre;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerTutores;
    }
}

