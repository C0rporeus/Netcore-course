using System;
using System.Collections.Generic;
using System.Linq;
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
            else {
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
        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}