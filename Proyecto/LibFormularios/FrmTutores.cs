using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmTutores : Form
    {
        public FrmTutores()
        {
            InitializeComponent();
        }

        private void FrmTutores_Load(object sender, EventArgs e)
        {
            cEntidad Docente = new cDocente();
            dgvTutores.DataSource = Docente.ListaGeneral();
            //string Codigo = @"select * from Docente where
            //    (Clase = 'Nombrado') or (Clase = 'Contratado' and (Regimen = 'A1' or Regimen = 'B1'))";
        }
    }
}
