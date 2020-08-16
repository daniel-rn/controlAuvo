using ControlAuvo.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlAuvo.Data.Context
{
    public class ControlAuvoDbcontext : DbContext
    {
        public ControlAuvoDbcontext(DbContextOptions<ControlAuvoDbcontext> options)
            : base(options)
        {
        }

        public DbSet<Registro> Registros { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
