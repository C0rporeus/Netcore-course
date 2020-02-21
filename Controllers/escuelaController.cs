using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;
namespace NetCore_Estudio.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {
            ViewBag.Dinamico = "La monja";
            var escuela = _context.Escuelas.FirstOrDefault();

            return View(escuela);
        } 
        public EscuelaController(EscuelaContext context)
        {
                  _context = context;
        }
    }
}