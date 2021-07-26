﻿using System;
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
        public cDocente() : base("Docente")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"Nombres", "ApellidoPaterno","ApellidoMaterno","Clase",
                "Categoria","Regimen","CarreraProfesional"};
        }

    }
}
