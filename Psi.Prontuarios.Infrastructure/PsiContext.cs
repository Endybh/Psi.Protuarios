using Microsoft.EntityFrameworkCore;
using Psi.Eliane.Core;
using Psi.Eliane.Core.Domain.Entities;

namespace Psi.Eliane.Infrastructure;

public class PsiContext:DbContext
{
    public DbSet<Paciente> Pacientes{get;set;}
    public DbSet<Prontuario> Prontuarios{get;set;}
    public PsiContext(DbContextOptions<PsiContext> options)
        :base(options)
    {     
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PacienteDbConfiguration());

        modelBuilder.ApplyConfiguration(new ProntuarioDbConfiguration());        
    }
}