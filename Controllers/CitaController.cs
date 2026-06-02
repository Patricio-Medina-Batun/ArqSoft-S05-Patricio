using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using System;                     
using CitasAPP.Models;            

namespace CitasAPP.Controllers
{
    public class CitaController : Controller
    {
        private static List<Cita> listaCitas = new List<Cita>
        {
            new Cita
            {
                Id = 1,
                PacienteId = 1,
                MedicoId = 1,
                Fecha = new DateOnly(2026, 6, 1), 
                Hora = new TimeOnly(9, 0),        
                Motivo = "Consulta general",
                Estado = EstadoCita.Confirmada    
            },
            new Cita
            {
                Id = 2,
                PacienteId = 2,
                MedicoId = 2,
                Fecha = new DateOnly(2026, 6, 1),
                Hora = new TimeOnly(10, 0),       
                Motivo = "Revisión de resultados",
                Estado = EstadoCita.Pendiente
            },
            new Cita
            {
                Id = 3,
                PacienteId = 3,
                MedicoId = 1,
                Fecha = new DateOnly(2026, 6, 3), 
                Hora = new TimeOnly(11, 0),       
                Motivo = "Primera consulta",
                Estado = EstadoCita.Pendiente
            }
        };

        public IActionResult Index()
        {
            return View(listaCitas);
        }

        public IActionResult PorPaciente(int pacienteId)
        {
            var citasDelPaciente = listaCitas.FindAll(c => c.PacienteId == pacienteId);

            return View(citasDelPaciente);
        }
    }
}