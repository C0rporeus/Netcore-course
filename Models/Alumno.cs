using System;
using System.Collections.Generic;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Models
{
    // implmentacion de la herencia despues de los dos puntos en el nombre de la clase
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluacion {get; set;} = new List<Evaluacion>();

        internal static object Cast<T>()
        {
            throw new NotImplementedException();
        }
    }
}