using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models.Entites
{
    public class ProfissionalEspecialidade
    {
        public int ProfissionalId { get; set; }
        public Profissional Profissionais { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
