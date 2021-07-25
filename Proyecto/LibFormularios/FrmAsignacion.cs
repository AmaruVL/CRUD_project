using System;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmAsignacion : Form
    {

        private SQLConexion Conexion;

        public FrmAsignacion()
        {
            InitializeComponent();
            Conexion = new SQLConexion();
        }

        private void btnPasar2_Click(object sender, EventArgs e)
        {
            string Cod, Nombres, AP, AM, Carrera, Condicion;
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEstudiantes.SelectedRows)
                {
                    //Obtener datos de las filas selecionadas
                    Cod = row.Cells["Codigo"].Value.ToString();
                    Nombres = row.Cells["Nombres"].Value.ToString();
                    AP = row.Cells["AP"].Value.ToString();
                    AM = row.Cells["AM"].Value.ToString();
                    Carrera = row.Cells["Carrera"].Value.ToString();
                    Condicion = row.Cells["Condicion"].Value.ToString();

                    int index = dgvTutorias.Rows.Add();
                    dgvTutorias.Rows[index].Cells[0].Value = Cod;
                    dgvTutorias.Rows[index].Cells[1].Value = Nombres;
                    dgvTutorias.Rows[index].Cells[2].Value = AP;
                    dgvTutorias.Rows[index].Cells[3].Value = AM;
                    dgvTutorias.Rows[index].Cells[4].Value = Carrera;
                    dgvTutorias.Rows[index].Cells[5].Value = Condicion;
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }

            
        }
    }
}
