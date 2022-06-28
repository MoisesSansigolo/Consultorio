using Consultorio.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Map
{
    public class ConsultaMap : BaseMap<Consulta>
    {
        public ConsultaMap() : base("tb_consulta")
        {

        }
        public override void Configure(EntityTypeBuilder<Consulta> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Status).HasColumnName("status").HasDefaultValue(1);
            builder.Property(x => x.Preco).HasPrecision(7,2).HasColumnName("preco");
            builder.Property(x => x.Preco).HasColumnName("preco");
            builder.Property(x => x.DataHorario).HasColumnName("data_horario").IsRequired();
        }
    }
}
