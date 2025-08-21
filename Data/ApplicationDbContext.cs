using Microsoft.EntityFrameworkCore;
using WebHospital.Models;
using Zismed_Apis.Models;
using Zismed_Apis.Models.Dto;

namespace Zismed_Apis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        //public DbSet<Prueba> Pruebas { get; set; }


        public DbSet<GuardiaRegistro> GuardiaRegistro { get; set; }
        public DbSet<GuardiaSector> GuardiaSector { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Numerador_HC> Numerador_HC { get; set; }
        public DbSet<GuardiaTipoCuestionarioXSector> GuardiaTipoCuestionarioXSector { get; set; }
        public DbSet<GuardiaTipoCuestionario> GuardiaTipoCuestionario { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<PacienteGuardiaDto> PacientesGuardia { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PacienteGuardiaDto>().HasNoKey(); // Indica que esta entidad no tiene clave primaria
        }

    }
}