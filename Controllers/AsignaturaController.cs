using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View(
                new Asignatura
                {
                    Nombre = "Ingles",
                    Id = Guid.NewGuid().ToString()
                }
            );
        }
        public IActionResult Asignaturas()
        {


            var listadeAsignaturas = new List<Asignatura>() {
                new Asignatura{Nombre="Matematicas",
                               Id=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ciencias",
                               Id=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Español",
                               Id=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ingles",
                               Id=Guid.NewGuid().ToString()}
            };
            ViewBag.Dinamico = "Random";
            ViewBag.Fecha = DateTime.Now;

            return View("Asignaturas", listadeAsignaturas);
        }
    }
}