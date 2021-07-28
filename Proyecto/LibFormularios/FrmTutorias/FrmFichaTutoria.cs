using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using LibClases;

namespace LibFormularios.FrmTutorias
{
    public partial class FrmFichaTutoria : Form
    {
        private string[] ValuesAtr;
        string Clave;
        private cEntidad Estudiante = new cEstudiante();
        public FrmFichaTutoria(string[] Values)
        {
            InitializeComponent();
            ValuesAtr = Values;
        }

        #region Encriptacion
        public static string Encriptar(string Mensaje, string Clave)
        {
            //Política de Seguridad del Contenido (CSP)
            CspParameters CSApars = new CspParameters();
            CSApars.KeyContainerName = Clave; //Definir clave
            //Definir instacia RSA
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(CSApars);
            //Convertir mensaje en bytes
            byte[] Msg = Encoding.UTF8.GetBytes(Mensaje);
            //Encriptar mensaje
            byte[] MsgEncriptado = RSA.Encrypt(Msg, false);
            //Convertir bytes en cadena y retornar
            return Convert.ToBase64String(MsgEncriptado);
        }
        public static string Desencriptar(string MensajeEncriptado, string Clave)
        {
            try
            {
                //Política de Seguridad del Contenido (CSP)
                CspParameters CSApars = new CspParameters();
                CSApars.KeyContainerName = Clave;//Definir clave
                //Definir instacia RSA
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(CSApars);
                //Converitir mensaje en bytes
                byte[] MsgDesencriptado = Convert.FromBase64String(MensajeEncriptado);
                //Desencriptar mensaje
                byte[] Msg = RSA.Decrypt(MsgDesencriptado, false);
                //Convertir bytes en cadena y retornar
                return Encoding.UTF8.GetString(Msg);
            }
            catch (Exception e)
            {
                Console.WriteLine("Clave incorrecta" + e);
                return null;
            }
        }

        #endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FrmFichaTutoria_Load(object sender, EventArgs e)
        {
            
            //IDTutoria, CodDocente, CodEstudiante, Semestre, Fecha, Descripcion;
            tbSemestre.Text = ValuesAtr[3];
            tbCodigo.Text = ValuesAtr[2];
            tbFecha.Text = ValuesAtr[4];
            //tbDescripcion.Text = 

            //tbAP.Text = Estudiante.ValorAtributo("ApellidoPaterno");
            //tbAM.Text = Estudiante.ValorAtributo("ApellidoMaterno");
            //tbNombre.Text = Estudiante.ValorAtributo("Nombres");
            //tbCarrera.Text = Estudiante.ValorAtributo("CarreraProfesional");
            //tbCondicion.Text = Estudiante.ValorAtributo("Condicion");
        }
    }
}
