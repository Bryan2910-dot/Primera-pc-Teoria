using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Primera_pc_Teoria.Models;

namespace Primera_pc_Teoria.Controllers
{
    
    public class BoletaController : Controller
    {
        private readonly ILogger<BoletaController> _logger;

        public BoletaController(ILogger<BoletaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Boleta boleta)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _logger.LogInformation("Se registró el contacto");
                    ViewData["Message"] = "Se registró la boleta";
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error al registrar el contacto");
                    ViewData["Message"] = "Error al registrar el contacto: " + ex.Message;
                }
            }
            else
            {
                ViewData["Message"] = "Datos de entrada no válidos";
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}