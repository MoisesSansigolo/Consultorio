﻿// <auto-generated />
using System;
using Consultorio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Consultorio.Migrations
{
    [DbContext(typeof(ConsultorioContext))]
    [Migration("20220629141142_RalaçaoUmParaMuitos")]
    partial class RalaçaoUmParaMuitos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Consultorio.Models.Entites.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DataHorario")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_horario");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("integer");

                    b.Property<int>("PacienteId")
                        .HasColumnType("integer")
                        .HasColumnName("id_paciente");

                    b.Property<decimal>("Preco")
                        .HasPrecision(7, 2)
                        .HasColumnType("numeric(7,2)")
                        .HasColumnName("preco");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("tb_consulta");
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Ativa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("ativa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_especialidade");
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("celular");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_paciente");
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("ativo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tb_profissional");
                });

            modelBuilder.Entity("EspecialidadeProfissional", b =>
                {
                    b.Property<int>("EspecialidadesId")
                        .HasColumnType("integer");

                    b.Property<int>("ProfissionaisId")
                        .HasColumnType("integer");

                    b.HasKey("EspecialidadesId", "ProfissionaisId");

                    b.HasIndex("ProfissionaisId");

                    b.ToTable("EspecialidadeProfissional");
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Consulta", b =>
                {
                    b.HasOne("Consultorio.Models.Entites.Especialidade", "Especialidade")
                        .WithMany("Consultas")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Models.Entites.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Models.Entites.Profissional", "Profissional")
                        .WithMany("Consultas")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");

                    b.Navigation("Paciente");

                    b.Navigation("Profissional");
                });

            modelBuilder.Entity("EspecialidadeProfissional", b =>
                {
                    b.HasOne("Consultorio.Models.Entites.Especialidade", null)
                        .WithMany()
                        .HasForeignKey("EspecialidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Models.Entites.Profissional", null)
                        .WithMany()
                        .HasForeignKey("ProfissionaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Especialidade", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Paciente", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("Consultorio.Models.Entites.Profissional", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
