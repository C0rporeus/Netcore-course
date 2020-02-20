using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(
                new Alumno
                {
                    Nombre = "Juan Jose",
                    Id = Guid.NewGuid().ToString()
                }
            );
        }
        public IActionResult Alumnos()
        {

            var listadeAlumnos = GenerarAlumnosAlAzar();
            /* var listadeAlumnos = new List<Alumno>() {
                new Alumno{Nombre="Mateo",
                               UniqueId=Guid.NewGuid().ToString()},
                new Alumno{Nombre="Andres",
                               UniqueId=Guid.NewGuid().ToString()},
                new Alumno{Nombre="Jaime",
                               UniqueId=Guid.NewGuid().ToString()},
                new Alumno{Nombre="Julian",
                               UniqueId=Guid.NewGuid().ToString()}
            }; */
            ViewBag.Dinamico = "Random";
            ViewBag.Fecha = DateTime.Now;

            return View("Alumnos", listadeAlumnos);
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
    }
}