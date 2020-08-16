using ControlAuvo.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlAuvo.Data.Mappings
{
    public class RegistroMapping : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("Registros");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Tipo)
                .IsRequired()
                .HasColumnType("integer");
        }
    }
}
