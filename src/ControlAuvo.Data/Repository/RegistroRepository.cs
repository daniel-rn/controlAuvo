using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlAuvo.Business.Interfaces.repositories;
using ControlAuvo.Business.Models;
using ControlAuvo.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ControlAuvo.Data.Repository
{
    public class RegistroRepository : Repository<Registro>, IRegistroRepository
    {
        private readonly ControlAuvoDbcontext _db;

        public RegistroRepository(ControlAuvoDbcontext db) : base(db)
        {
            _db = db;
        }

        public override async Task<List<Registro>> ObterTodos()
        {
            return await DbSet
                .Include(c => c.Empregado)
                .ToListAsync();
        }

        public override async Task Adicionar(Registro entity)
        {
            var usu = _db.Employees.FirstOrDefault(d => d.Nome == entity.Empregado.Nome);

            if (usu != null)
            {
                entity.Empregado = usu;
            }

            await base.Adicionar(entity);
        }
    }
}
