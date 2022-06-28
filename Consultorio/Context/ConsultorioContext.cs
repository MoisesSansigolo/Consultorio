using Consultorio.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options)
        {

        }

        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
