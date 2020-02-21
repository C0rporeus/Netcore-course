using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;

namespace NetCore_Estudio.Controllers
{
    public class AsignaturaController : Controller
    {
        /* public IActionResult Index()
        {
            return View(
                _context.Asignaturas.FirstOrDefault()
            );
        } */
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId?}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas
                                 where asig.Id == asignaturaId
                                 select asig;
                return View(asignatura.SingleOrDefault());
            }
            else {
                return View("Asignaturas", _context.Asignaturas);
            }

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