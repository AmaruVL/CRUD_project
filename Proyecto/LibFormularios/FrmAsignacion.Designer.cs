
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvTutorias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPasar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombres,
            this.AP,
            this.AM,
            this.Carrera,
            this.Condicion});
            this.dgvEstudiantes.Location = new System.Drawing.Point(26, 84);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.Size = new System.Drawing.Size(359, 344);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // AP
            // 
            this.AP.HeaderText = "AP";
            this.AP.Name = "AP";
            // 
            // AM
            // 
            this.AM.HeaderText = "AM";
            this.AM.Name = "AM";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(632, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 27);
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
            this.btnConfirmar.Location = new System.Drawing.Point(747, 453);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(657, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvTutorias
            // 
            this.dgvTutorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvTutorias.Location = new System.Drawing.Point(493, 84);
            this.dgvTutorias.Name = "dgvTutorias";
            this.dgvTutorias.Size = new System.Drawing.Size(359, 344);
            this.dgvTutorias.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "AP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "AM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Carrera";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Condición";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnPasar2
            // 
            this.btnPasar2.Location = new System.Drawing.Point(407, 238);
            this.btnPasar2.Name = "btnPasar2";
            this.btnPasar2.Size = new System.Drawing.Size(58, 23);
            this.btnPasar2.TabIndex = 3;
            this.btnPasar2.Text = "-->";
            this.btnPasar2.UseVisualStyleBackColor = true;
            //this.btnPasar2.Click += new System.EventHandler(this.btnPasar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPasar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvTutorias);
            this.Controls.Add(this.dgvEstudiantes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvTutorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.Button btnPasar2;
    }
}

