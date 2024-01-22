using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psi.Eliane.Core.Domain.Entities;

namespace Psi.Eliane.Infrastructure;

public class PacienteDbConfiguration : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.HasKey(e=>e.Id);

        builder.Property(e=>e.Name);

        builder.Property(e=>e.Phone);
        
        builder.Property(e=>e.Document);

        builder.Property(e=>e.ReferencePhoneOne);
        
        builder.Property(e=>e.ReferencePhoneTwo);

        builder.Property(e=>e.Address);

        builder.ToTable("paciente");
    }
}
