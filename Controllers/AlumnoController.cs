using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Controllers
{
    public class AlumnoController : Controller
    {
        [Route("Alumno/{id}")]
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{id}")]
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from alum in _context.Alumnos
                                 where alum.Id == id
                                 select alum;
                return View(alumno.SingleOrDefault());
            }
            else {
                return View("Alumnos", _context.Alumnos);
            }

        }
        public IActionResult Alumnos()
        {
            ViewBag.Dinamico = "Random";
            ViewBag.Fecha = DateTime.Now;

            return View("Alumnos", _context.Alumnos);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}