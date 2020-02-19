using System;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;
namespace NetCore_Estudio.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new EscuelaModel();
            escuela.AñoFundacion = 2020;
            escuela.EscuelaId= Guid.NewGuid().ToString();
            escuela.Nombre= "Horizonte del sol";

            return View(escuela);
        } 
    }
}