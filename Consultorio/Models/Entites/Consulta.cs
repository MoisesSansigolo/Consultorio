using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models.Entites
{
    public class Consulta : Base
    {
        public DateTime DataHorario { get; set; }
        public int Status { get; set; }
        public decimal Preco { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }
    }
}
