using System;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmDocente : FrmPadre
    {
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new cDocente());
        }
        //======definicion de los metodos virtuales=======

        //--EStablecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {TbCodigo.Text,TbPaterno.Text,TbMaterno.Text,TbNombre.Text,
            TbIdentificacion.Text,TbTelefono.Text,TbDepartamento.Text,TbCondicion.Text,TbCategoria.Text,
            TbRegimen.Text,TbGrado.Text};
        }
        //----------------------------------------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de cDocente
            TbPaterno.Text = aEntidad.ValorAtributo("APaterno");
            TbMaterno.Text = aEntidad.ValorAtributo("AMaterno");
            TbNombre.Text = aEntidad.ValorAtributo("Nombre");
            TbIdentificacion.Text = aEntidad.ValorAtributo("Identificacion");
            TbTelefono.Text = aEntidad.ValorAtributo("Telefono");
            TbDepartamento.Text = aEntidad.ValorAtributo("Departamento");
            TbCondicion.Text = aEntidad.ValorAtributo("Condicion");
            TbCategoria.Text = aEntidad.ValorAtributo("Categoria");
            TbRegimen.Text = aEntidad.ValorAtributo("Regimen");
            TbGrado.Text = aEntidad.ValorAtributo("Grado");
        }
        //----------------------------------------------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TbCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TbPaterno.Text = "";
            TbMaterno.Text = "";
            TbNombre.Text = "";
            TbIdentificacion.Text = "";
            TbTelefono.Text = "";
            TbDepartamento.Text = "";
            TbCondicion.Text = "";
            TbCategoria.Text = "";
            TbRegimen.Text = "";
            TbGrado.Text = "";
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
            if (TbCodigo.Text.Trim() != "" && TbNombre.Text.Trim() != "")
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
        
    }
}
