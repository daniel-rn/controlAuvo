using ControlAuvo.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlAuvo.Data.Mappings
{
    public class EmployeeMappings : IEntityTypeConfiguration<Empregado>
    {
        public void Configure(EntityTypeBuilder<Empregado> builder)
        {
            builder.ToTable("Empregado");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(c => c.Registros)
                .WithOne(a => a.Empregado)
                .HasForeignKey(a => a.Empregado.Id);
        }
    }
}
