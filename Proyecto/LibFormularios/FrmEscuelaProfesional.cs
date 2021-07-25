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
    public partial class FrmEscuelaProfesional : FrmPadre
    {
        public FrmEscuelaProfesional()
        {
            InitializeComponent();
            IniciarEntidad(new cEscuelaProfesional());
        }
        //======definicion de los metodos virtuales=======

        //--EStablecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] {TbCodigoEscuela.Text,TbNombreEscuela.Text};
        }
        //----------------------------------------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de cEscuelaProfesional
            TbNombreEscuela.Text = aEntidad.ValorAtributo("Nombre");
        }
        //----------------------------------------------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TbCodigoEscuela.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TbNombreEscuela.Text = "";
        }
        //----------------------------------------------------------------------------------------------
        //-- Listar los registros y mostrrlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos las escuelas de la tabla en el grid
            DgvEscuelaProfesional.DataSource = aEntidad.ListaGeneral();
        }
        //----------------------------------------------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y nombre) esten llenos
        public override bool EsRegistroValido()
        {
            if (TbCodigoEscuela.Text.Trim() != "" && TbNombreEscuela.Text.Trim() != "")
                return true;
            else
                return false;
        }

        private void TbCodigoEscuela_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmEscuelaProfesional_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
