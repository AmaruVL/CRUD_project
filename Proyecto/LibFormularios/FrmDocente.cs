using System;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmDocente : FrmPadre
    {
        private string CodDocente = "";
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new cDocente());
        }
        //======definicion de los metodos virtuales=======

        //--EStablecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {tbNombre.Text,tbAP.Text,tbAM.Text,tbClase.Text
            ,tbCategoria.Text,tbRegimen.Text,tbCarrera.Text};
        }
        //----------------------------------------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de cDocente
            tbAP.Text = aEntidad.ValorAtributo("APaterno");
            tbAM.Text = aEntidad.ValorAtributo("AMaterno");
            tbNombre.Text = aEntidad.ValorAtributo("Nombre");
            tbCategoria.Text = aEntidad.ValorAtributo("Categoria");
            tbRegimen.Text = aEntidad.ValorAtributo("Regimen");
        }
        //----------------------------------------------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            //tbCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            tbNombre.Text = "";
            tbAP.Text = "";
            tbAM.Text = "";
            tbClase.Text = "";
            tbCategoria.Text = "";
            tbRegimen.Text = "";
            tbCarrera.Text = "";
        }
        //----------------------------------------------------------------------------------------------
        //-- Listar los registros y mostrrlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos los docentes de la tabla en el grid
            DgvDocente.DataSource = aEntidad.ListaGeneral();
        }
        //----------------------------------------------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y nombre) esten llenos
        public override bool EsRegistroValido()
        {
            // if (tbCodigo.Text.Trim() != "" && tbNombre.Text.Trim() != "")
            if (tbNombre.Text.Trim() != "")
                return true;
            else
                return false;
        }
        //===============EVENTOS===========================
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmDocente_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //--Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //-- Verificar si existe clave primaria
                    aEntidad.Insertar(Atributos);
                    //-- Inicializar el formulario
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE :D", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        public override void Editar()
        {
            //base.Editar();
            try
            {
                if (DgvDocente.SelectedRows.Count > 0)
                {
                    CodDocente = DgvDocente.CurrentRow.Cells["Codigo"].Value.ToString();
                    tbNombre.Text = DgvDocente.CurrentRow.Cells["Nombres"].Value.ToString();
                    tbAP.Text = DgvDocente.CurrentRow.Cells["AP"].Value.ToString();
                    tbAM.Text = DgvDocente.CurrentRow.Cells["AM"].Value.ToString();
                    tbClase.Text = DgvDocente.CurrentRow.Cells["Clase"].Value.ToString();
                    tbCategoria.Text = DgvDocente.CurrentRow.Cells["Categoria"].Value.ToString();
                    tbRegimen.Text = DgvDocente.CurrentRow.Cells["Regimen"].Value.ToString();
                    tbCarrera.Text = DgvDocente.CurrentRow.Cells["Carrera"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA FILA PARA EDITAR", "ERROR");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
    }
}
