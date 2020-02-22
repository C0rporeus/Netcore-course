using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCore_Estudio.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage="Nombre requerido")]
        [StringLength(5)]
        [MinLength(3, ErrorMessage="El nombre del curso no puede ser menor de 3 caracteres...")]
        public override string Nombre {get; set; }
        public string EscuelaId {get; set; }
        public Escuela Escuela {get; set;}
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Direccion { get; set; }
        
    }
}