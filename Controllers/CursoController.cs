using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Controllers
{
    public class CursoController : Controller
    {


        [Route("Curso/")]
        [Route("Curso/{id}")]
        [Route("Curso/Index")]
        [Route("Curso/Index/{id}")]
        public IActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return View("Cursos", _context.Cursos);
            }
            else
            {
                var curso = from cur in _context.Cursos
                            where cur.Id == id
                            select cur;
                return View(curso.SingleOrDefault());
            }
        }
        public IActionResult Cursos()
        {
            ViewBag.Dinamico = "Random";
            ViewBag.Fecha = DateTime.Now;

            return View("Cursos", _context.Cursos);
        }

        public IActionResult Create()
        {

            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.mensaje = "Creado correctamente";
                return View("index", curso);
            }
            else
            {
                return View(curso);
            }
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

    }
}