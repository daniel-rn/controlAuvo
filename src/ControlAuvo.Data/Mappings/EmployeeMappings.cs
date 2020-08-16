using ControlAuvo.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlAuvo.Data.Mappings
{
    public class EmployeeMappings : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(c => c.Registros)
                .WithOne(a => a.Employee)
                .HasForeignKey(a => a.Employee.Id);
        }
    }
}
