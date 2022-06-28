using Consultorio.Models.Entites;
using Consultorio.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IEmailService _emailService;

        List<Agendamento> agendamentos = new List<Agendamento>();

        public AgendamentoController(IEmailService emailService)
        {
            agendamentos.Add(new Agendamento { Id = 1, NomePaciente = "Jonathan", Horario = new DateTime(2022, 07, 18)});

            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           var agendamentoSelecionado = agendamentos.FirstOrDefault(x => x.Id == id);
            return agendamentoSelecionado != null ? Ok(agendamentoSelecionado) : BadRequest("Erro ao buscar o agendamento");

        }

        [HttpPost]
        public IActionResult Post()
        {
            var pacienteAgendado = true;

            if (pacienteAgendado)
            {
                _emailService.EnviarEmail("moises.sansigolo@gmail.com");
            }
        return Ok();
        }
    }
       
}
