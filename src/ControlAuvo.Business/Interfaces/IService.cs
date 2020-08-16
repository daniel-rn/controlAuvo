using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlAuvo.Business.Interfaces
{
    public interface IService<T>
    {
        Task Adicione(T entity);
        Task Atualize(T entity);
        Task Remove(Guid id);
        Task<List<T>> ObterTodos();
        Task<T> Consultar(Guid? id);
    }
}
