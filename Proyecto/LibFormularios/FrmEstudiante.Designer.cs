
namespace LibFormularios
{
    partial class FrmEstudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.btnFiltrarEst = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.cbCondicion);
            this.panel2.Controls.Add(this.dgvEstudiante);
            this.panel2.Controls.Add(this.lblNombres);
            this.panel2.Controls.Add(this.lblCondicion);
            this.panel2.Controls.Add(this.lblCarrera);
            this.panel2.Controls.Add(this.lblAM);
            this.panel2.Controls.Add(this.lblAP);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.tbCarrera);
            this.panel2.Controls.Add(this.tbAM);
            this.panel2.Controls.Add(this.tbAP);
            this.panel2.Controls.Add(this.tbNombres);
            this.panel2.Controls.Add(this.tbCodigo);
            this.panel2.Size = new System.Drawing.Size(801, 373);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(801, 49);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.LblTitulo.Size = new System.Drawing.Size(801, 49);
            this.LblTitulo.Text = "INFORMACIÓN ESTUDIANTE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.btnFiltrarEst);
            this.panel3.Location = new System.Drawing.Point(0, 422);
            this.panel3.Size = new System.Drawing.Size(801, 44);
            this.panel3.Controls.SetChildIndex(this.btnFiltrarEst, 0);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(116, 39);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(116, 65);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(100, 20);
            this.tbNombres.TabIndex = 0;
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(116, 91);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(100, 20);
            this.tbAP.TabIndex = 0;
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(116, 117);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(100, 20);
            this.tbAM.TabIndex = 0;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(116, 143);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(100, 20);
            this.tbCarrera.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(12, 91);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(89, 13);
            this.lblAP.TabIndex = 1;
            this.lblAP.Text = "Apellido paterno: ";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(12, 68);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(12, 120);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(88, 13);
            this.lblAM.TabIndex = 1;
            this.lblAM.Text = "Apellido materno:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(12, 146);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(98, 13);
            this.lblCarrera.TabIndex = 1;
            this.lblCarrera.Text = "Carrera profesional:";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(12, 172);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(57, 13);
            this.lblCondicion.TabIndex = 1;
            this.lblCondicion.Text = "Condición:";
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            this.dgvEstudiante.AllowUserToResizeRows = false;
            this.dgvEstudiante.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(254, 24);
            this.dgvEstudiante.MultiSelect = false;
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEstudiante.RowHeadersWidth = 25;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEstudiante.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(522, 324);
            this.dgvEstudiante.TabIndex = 2;
            // 
            // cbCondicion
            // 
            this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Items.AddRange(new object[] {
            "Normal",
            "En riesgo"});
            this.cbCondicion.Location = new System.Drawing.Point(116, 172);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(100, 21);
            this.cbCondicion.TabIndex = 3;
            // 
            // btnFiltrarEst
            // 
            this.btnFiltrarEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(68)))));
            this.btnFiltrarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEst.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarEst.Location = new System.Drawing.Point(557, 6);
            this.btnFiltrarEst.Name = "btnFiltrarEst";
            this.btnFiltrarEst.Size = new System.Drawing.Size(105, 28);
            this.btnFiltrarEst.TabIndex = 17;
            this.btnFiltrarEst.Text = "Filtrar";
            this.btnFiltrarEst.UseVisualStyleBackColor = false;
            this.btnFiltrarEst.Click += new System.EventHandler(this.btnFiltrarEst_Click);
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Name = "FrmEstudiante";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cbCondicion;
        public System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.Button btnFiltrarEst;
    }
}