using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ControlAuvo.Business.Interfaces;
using ControlAuvo.Business.Interfaces.repositories;
using ControlAuvo.Business.Interfaces.services;
using ControlAuvo.Business.Models;

namespace ControlAuvo.Business.Services
{
    public class RegistroService : BaseService, IRegistroService
    {
        private readonly IRegistroRepository _registroRepository;

        public RegistroService(INotifier notificador, IRegistroRepository registroEntradaRepository)
            : base(notificador)
        {
            _registroRepository = registroEntradaRepository;
        }

        public async Task Adicione(Registro entity)
        {
            await _registroRepository.Adicionar(entity);
        }

        public async Task Atualize(Registro entity)
        {
            await _registroRepository.Atualizar(entity);
        }

        public async Task Remove(Guid id)
        {
            await _registroRepository.Remover(id);
        }

        public async Task<List<Registro>> ObterTodos()
        {
            return await _registroRepository.ObterTodos();
        }

        public async Task<Registro> Consultar(Guid? id)
        {
            return await _registroRepository.ObterPorId(id);
        }
    }
}
