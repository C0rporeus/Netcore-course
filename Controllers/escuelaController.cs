using System;
using Microsoft.AspNetCore.Mvc;
using NetCore_Estudio.Models;
namespace NetCore_Estudio.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2020;
            escuela.UniqueId= Guid.NewGuid().ToString();
            escuela.Nombre= "Horizonte del sol";
            escuela.Direccion= "Cll 81 - 20";
            escuela.Pais= "Peru";
            escuela.Ciudad="Lima";
            escuela.TipoEscuela=TiposEscuela.Primaria;
            ViewBag.Dinamico = "La monja";


            return View(escuela);
        } 
    }
}