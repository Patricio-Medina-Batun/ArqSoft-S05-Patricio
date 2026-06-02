using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using CitasAPP.Models;            

namespace CitasAPP.Controllers
{
    public class MedicoController : Controller
    {
        private static List<Medico> listaMedicos = new List<Medico>
        {
            new Medico { Id = 1, Nombre = "Dr. Carlos", Apellido = "Reyes", Especialidad = "Medicina General", NumeroLicencia = "MG-10421" },
            new Medico { Id = 2, Nombre = "Dra. Patricia", Apellido = "Vega", Especialidad = "Pediatría", NumeroLicencia = "PD-20835" },
            new Medico { Id = 3, Nombre = "Dr. Roberto", Apellido = "Sánchez", Especialidad = "Cardiología", NumeroLicencia = "CA-30117" }
        };
        public IActionResult Index()
        {
            return View(listaMedicos);
        }

        public IActionResult Detalle(int id)
        {

            var medicoEncontrado = listaMedicos.Find(m => m.Id == id);

            return View(medicoEncontrado);
        }
    }
}