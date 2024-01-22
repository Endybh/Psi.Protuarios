using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Eliane.Core.Domain.Entities;

namespace Psi.Eliane.Infrastructure;

public class ProntuarioDbConfiguration : IEntityTypeConfiguration<Prontuario>
{
    public void Configure(EntityTypeBuilder<Prontuario> builder)
    {
        builder.HasKey(e=>e.Id);
        
        builder.Property(e=>e.DataSessao);

        builder.Property(e=>e.Memo);

        builder.Property(e=>e.PacienteFkId);

        builder.HasOne(e=>e.Paciente)
            .WithMany().HasForeignKey(p=>p.PacienteFkId);
        
        builder.ToTable("prontuario");
    }
}