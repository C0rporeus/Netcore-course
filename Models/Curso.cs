using System;
using System.Collections.Generic;

namespace NetCore_Estudio.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        public string EscuelaId {get; set; }
        public Escuela Escuela {get; set;}
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Direccion { get; set; }
        
    }
}