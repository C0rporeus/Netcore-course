using System;
using System.Linq;
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
                _context.Asignaturas.FirstOrDefault()
            );
        }
        public IActionResult Asignaturas()
        {
            
            ViewBag.Dinamico = "Random";
            ViewBag.Fecha = DateTime.Now;

            return View("Asignaturas", _context.Asignaturas);
        }
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}