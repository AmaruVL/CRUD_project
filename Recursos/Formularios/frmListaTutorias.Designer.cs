
namespace Formularios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloFormTurorias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.btMax = new System.Windows.Forms.Button();
            this.btX = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btRestaurar);
            this.panel1.Controls.Add(this.btMin);
            this.panel1.Controls.Add(this.btMax);
            this.panel1.Controls.Add(this.btX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloFormTurorias
            // 
            this.lblTituloFormTurorias.AutoSize = true;
            this.lblTituloFormTurorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormTurorias.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloFormTurorias.Location = new System.Drawing.Point(31, 71);
            this.lblTituloFormTurorias.Name = "lblTituloFormTurorias";
            this.lblTituloFormTurorias.Size = new System.Drawing.Size(304, 32);
            this.lblTituloFormTurorias.TabIndex = 1;
            this.lblTituloFormTurorias.Text = "LISTA DE TUTORÍAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(37, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 317);
            this.dataGridView1.TabIndex = 2;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btGuardar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btGuardar.Location = new System.Drawing.Point(37, 548);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(165, 33);
            this.btGuardar.TabIndex = 17;
            this.btGuardar.Text = "Ver";
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btCerrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btCerrar.Location = new System.Drawing.Point(423, 548);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(165, 33);
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
            this.tbBuscar.Location = new System.Drawing.Point(397, 137);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(158, 27);
            this.tbBuscar.TabIndex = 19;
            this.tbBuscar.Text = "Buscar...";
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = global::Formularios.Properties.Resources.loupe;
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.Location = new System.Drawing.Point(552, 137);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(36, 27);
            this.btBuscar.TabIndex = 20;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btRestaurar
            // 
            this.btRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestaurar.BackgroundImage = global::Formularios.Properties.Resources.minimize__1_;
            this.btRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRestaurar.Location = new System.Drawing.Point(548, 3);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(34, 30);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Visible = false;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btMin
            // 
            this.btMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMin.BackgroundImage = global::Formularios.Properties.Resources.minimize;
            this.btMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMin.Location = new System.Drawing.Point(508, 3);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(34, 30);
            this.btMin.TabIndex = 2;
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btMax
            // 
            this.btMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMax.BackgroundImage = global::Formularios.Properties.Resources.maximize_size_option;
            this.btMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMax.Location = new System.Drawing.Point(548, 4);
            this.btMax.Name = "btMax";
            this.btMax.Size = new System.Drawing.Size(34, 30);
            this.btMax.TabIndex = 1;
            this.btMax.UseVisualStyleBackColor = true;
            this.btMax.Click += new System.EventHandler(this.btMax_Click);
            // 
            // btX
            // 
            this.btX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btX.BackgroundImage = global::Formularios.Properties.Resources.close;
            this.btX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btX.Location = new System.Drawing.Point(588, 4);
            this.btX.Name = "btX";
            this.btX.Size = new System.Drawing.Size(34, 30);
            this.btX.TabIndex = 0;
            this.btX.UseVisualStyleBackColor = true;
            this.btX.Click += new System.EventHandler(this.btX_Click);
            // 
            // frmListaTutorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 612);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTituloFormTurorias);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaTutorias";
            this.Text = "frmListaTutorias";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btMax;
        private System.Windows.Forms.Button btX;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Label lblTituloFormTurorias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
    }
}