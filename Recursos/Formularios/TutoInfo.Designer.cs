
namespace Formularios
{
    partial class TutoInfo
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
            this.TituloForm = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.btVer = new System.Windows.Forms.Button();
            this.btOcultar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloForm
            // 
            this.TituloForm.AutoSize = true;
            this.TituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TituloForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TituloForm.Location = new System.Drawing.Point(281, 24);
            this.TituloForm.Name = "TituloForm";
            this.TituloForm.Size = new System.Drawing.Size(307, 31);
            this.TituloForm.TabIndex = 1;
            this.TituloForm.Text = "SESIÓN DE TUTORÍA";
            // 
            // tbFecha
            // 
            this.tbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFecha.Location = new System.Drawing.Point(36, 89);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(137, 27);
            this.tbFecha.TabIndex = 4;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbFecha.Location = new System.Drawing.Point(35, 66);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(60, 20);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha";
            // 
            // tbVer
            // 
            this.tbVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbVer.Location = new System.Drawing.Point(409, 151);
            this.tbVer.Name = "tbVer";
            this.tbVer.PasswordChar = '*';
            this.tbVer.Size = new System.Drawing.Size(162, 27);
            this.tbVer.TabIndex = 5;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVer.Location = new System.Drawing.Point(351, 154);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(38, 20);
            this.lblVer.TabIndex = 6;
            this.lblVer.Text = "Ver";
            // 
            // btVer
            // 
            this.btVer.BackgroundImage = global::Formularios.Properties.Resources.view;
            this.btVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVer.Image = global::Formularios.Properties.Resources.view;
            this.btVer.Location = new System.Drawing.Point(543, 152);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(28, 26);
            this.btVer.TabIndex = 8;
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btOcultar
            // 
            this.btOcultar.BackgroundImage = global::Formularios.Properties.Resources.invisible;
            this.btOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOcultar.Location = new System.Drawing.Point(543, 151);
            this.btOcultar.Name = "btOcultar";
            this.btOcultar.Size = new System.Drawing.Size(28, 26);
            this.btOcultar.TabIndex = 7;
            this.btOcultar.UseVisualStyleBackColor = true;
            this.btOcultar.Click += new System.EventHandler(this.btOcultar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 195);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(110, 20);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Location = new System.Drawing.Point(47, 233);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(527, 163);
            this.tbDescripcion.TabIndex = 10;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btGuardar.Location = new System.Drawing.Point(409, 424);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(165, 33);
            this.btGuardar.TabIndex = 16;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // TutoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 525);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.btOcultar);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.TituloForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TutoInfo";
            this.Text = "TutoInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloForm;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Button btOcultar;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btGuardar;
    }
}