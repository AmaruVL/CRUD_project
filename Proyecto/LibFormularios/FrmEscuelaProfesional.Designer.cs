namespace LibFormularios
{
    partial class FrmEscuelaProfesional
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
            this.TbNombreEscuela = new System.Windows.Forms.TextBox();
            this.TbCodigoEscuela = new System.Windows.Forms.TextBox();
            this.DgvEscuelaProfesional = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEscuelaProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TbNombreEscuela);
            this.panel2.Controls.Add(this.TbCodigoEscuela);
            this.panel2.Controls.Add(this.DgvEscuelaProfesional);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Text = "INFORMACIÓN ESCUELA PROFESIONAL";
            // 
            // TbNombreEscuela
            // 
            this.TbNombreEscuela.Location = new System.Drawing.Point(260, 78);
            this.TbNombreEscuela.Name = "TbNombreEscuela";
            this.TbNombreEscuela.Size = new System.Drawing.Size(287, 20);
            this.TbNombreEscuela.TabIndex = 70;
            // 
            // TbCodigoEscuela
            // 
            this.TbCodigoEscuela.Location = new System.Drawing.Point(260, 56);
            this.TbCodigoEscuela.Name = "TbCodigoEscuela";
            this.TbCodigoEscuela.Size = new System.Drawing.Size(100, 20);
            this.TbCodigoEscuela.TabIndex = 69;
            this.TbCodigoEscuela.Leave += new System.EventHandler(this.TbCodigoEscuela_Leave);
            // 
            // DgvEscuelaProfesional
            // 
            this.DgvEscuelaProfesional.AllowUserToDeleteRows = false;
            this.DgvEscuelaProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvEscuelaProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEscuelaProfesional.Location = new System.Drawing.Point(156, 169);
            this.DgvEscuelaProfesional.Name = "DgvEscuelaProfesional";
            this.DgvEscuelaProfesional.ReadOnly = true;
            this.DgvEscuelaProfesional.Size = new System.Drawing.Size(396, 159);
            this.DgvEscuelaProfesional.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Codigo Escuela :";
            // 
            // FrmEscuelaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 462);
            this.Name = "FrmEscuelaProfesional";
            this.Text = "FrmEscuelaProfesional";
            this.Load += new System.EventHandler(this.FrmEscuelaProfesional_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEscuelaProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbNombreEscuela;
        private System.Windows.Forms.TextBox TbCodigoEscuela;
        private System.Windows.Forms.DataGridView DgvEscuelaProfesional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}