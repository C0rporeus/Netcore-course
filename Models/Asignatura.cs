using System;
using System.Collections.Generic;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Models
{
    public class Asignatura : ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso {get; set;}

        public List<Evaluacion> Evaluaciones {get; set;}
    }
}