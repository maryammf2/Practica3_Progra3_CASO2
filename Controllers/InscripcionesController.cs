using Microsoft.AspNetCore.Mvc;
using Practica3_Progra3_CASO2.Models;
using Practica3_Progra3_CASO2.Data;
using System;

namespace Practica3_Progra3_CASO2.Controllers
{
    public class InscripcionController : Controller
    {

        public IActionResult Index()
        {
            var lista = InscripcionRepository.ObtenerInscripciones();
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View(new Inscripcion { FechaTaller = DateTime.Today });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Inscripcion inscripcion)
        {
            if (inscripcion.FechaTaller.Date < DateTime.Today)
                ModelState.AddModelError(nameof(inscripcion.FechaTaller), "La fecha del taller no puede ser anterior a la fecha actual.");
            if (!inscripcion.AceptaTerminos)
                ModelState.AddModelError(nameof(inscripcion.AceptaTerminos), "Acepte los términos y condiciones para completar la inscripción");

            if (!ModelState.IsValid)
                return View(inscripcion);

            InscripcionRepository.AgregarInscripcion(inscripcion);

            TempData["SuccessMessage"] = "Inscripción registrada de manera correcta.";
            return RedirectToAction(nameof(Index));
        }
    }
}