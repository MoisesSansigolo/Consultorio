﻿using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;

        public PacienteController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pacientes = _repository.Get();
            return pacientes.Any()
                ? Ok(pacientes)
                : BadRequest("Paciente não encontrado");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var paciente = _repository.GetById(id);
            return paciente != null
                ? Ok(paciente)
                : BadRequest("Paciente não cadastrado");
        }
    }

}
