
namespace LibFormularios
{
    partial class frmListaTutorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloFormTurorias = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvListaTutoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTutoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormTurorias
            // 
            this.lblTituloFormTurorias.AutoSize = true;
            this.lblTituloFormTurorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormTurorias.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloFormTurorias.Location = new System.Drawing.Point(33, 35);
            this.lblTituloFormTurorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloFormTurorias.Name = "lblTituloFormTurorias";
            this.lblTituloFormTurorias.Size = new System.Drawing.Size(241, 26);
            this.lblTituloFormTurorias.TabIndex = 1;
            this.lblTituloFormTurorias.Text = "LISTA DE TUTORÍAS";
            this.lblTituloFormTurorias.Click += new System.EventHandler(this.lblTituloFormTurorias_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btGuardar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btGuardar.Location = new System.Drawing.Point(100, 486);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(124, 27);
            this.btGuardar.TabIndex = 17;
            this.btGuardar.Text = "Ver";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btCerrar.Location = new System.Drawing.Point(659, 486);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(124, 27);
            this.btCerrar.TabIndex = 18;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBuscar.Location = new System.Drawing.Point(580, 74);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(230, 21);
            this.tbBuscar.TabIndex = 19;
            this.tbBuscar.Text = "Buscar...";
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = global::LibFormularios.Properties.Resources.loupe;
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.Location = new System.Drawing.Point(808, 74);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(27, 22);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvListaTutoria
            // 
            this.dgvListaTutoria.AllowUserToAddRows = false;
            this.dgvListaTutoria.AllowUserToDeleteRows = false;
            this.dgvListaTutoria.AllowUserToResizeRows = false;
            this.dgvListaTutoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaTutoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTutoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTutoria.Location = new System.Drawing.Point(38, 115);
            this.dgvListaTutoria.MultiSelect = false;
            this.dgvListaTutoria.Name = "dgvListaTutoria";
            this.dgvListaTutoria.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTutoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaTutoria.RowHeadersWidth = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListaTutoria.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaTutoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTutoria.Size = new System.Drawing.Size(805, 338);
            this.dgvListaTutoria.TabIndex = 21;
            // 
            // frmListaTutorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 606);
            this.Controls.Add(this.dgvListaTutoria);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lblTituloFormTurorias);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaTutorias";
            this.Text = "frmListaTutorias";
            this.Load += new System.EventHandler(this.frmListaTutorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTutoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloFormTurorias;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
        public System.Windows.Forms.DataGridView dgvListaTutoria;
    }
}