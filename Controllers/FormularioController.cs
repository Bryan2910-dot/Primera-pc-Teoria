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
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculo(Formulario form)
        {
            if (ModelState.IsValid)
            {
                string mensaje = "";
                try
                {
                    mensaje = $"resultado es : {form.Calcular()}";
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error en la operación");
                    mensaje = "Error en la operación: " + ex.Message;
                }
                    ViewData["Resultado"] = mensaje;
            }
            else
            {
                ViewData["Resultado"] = "Datos de entrada no válidos";
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