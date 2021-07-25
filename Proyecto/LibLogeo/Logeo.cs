﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;

namespace LibLogeo
{
    public partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "USUARIO")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "USUARIO";
                TxtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPasword_Enter(object sender, EventArgs e)
        {
            if (TxtPasword.Text == "CONTRASEÑA")
            {
                TxtPasword.Text = "";
                TxtPasword.ForeColor = Color.LightGray;
                TxtPasword.UseSystemPasswordChar = true;
            }
        }

        private void TxtPasword_Leave(object sender, EventArgs e)
        {
            if (TxtPasword.Text == "")
            {
                TxtPasword.Text = "CONTRASEÑA";
                TxtPasword.ForeColor = Color.DimGray;
                TxtPasword.UseSystemPasswordChar = false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            FrmEscuelaProfesional Escuela = new FrmEscuelaProfesional();
            Escuela.Show();
        }
    }
}