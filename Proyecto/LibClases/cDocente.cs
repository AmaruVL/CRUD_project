using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cDocente : cEntidad
    {   //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public cDocente() : base("TDocente")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"CodDocente","APaterno","AMaterno","Nombre","Identificacion","Telefono",
                "Departamento","Condicion","Categoria","Regimen","Grado"};
        }
    }
}
