using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models.Entites
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public DateTime Horario { get; set; }
    }
}
