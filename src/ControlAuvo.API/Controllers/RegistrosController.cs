using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ControlAuvo.API.ModelView;
using ControlAuvo.API.ModelView.Validations;
using ControlAuvo.Business.Interfaces;
using ControlAuvo.Business.Interfaces.services;
using ControlAuvo.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControlAuvo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosController : MainController
    {
        private readonly IRegistroService _registroService;

        public RegistrosController(INotifier notificador, IRegistroService registroService) : base(notificador)
        {
            _registroService = registroService;
        }

        //getALL
        [HttpGet("obtenhaTodos")]
        public async Task<ActionResult<IEnumerable<Registro>>> ObtenhaTodos()
        {
            var result = await _registroService.ObterTodos();

            return CustomResponse(result);
        }

        //getById
        [HttpGet("obterPorId/{id:guid}")]
        public async Task<ActionResult<Registro>> ObtenhaRegistroPorId(Guid id)
        {
            var result = await _registroService.Consultar(id);
            return CustomResponse(result);
        }

        //Post
        [HttpPost("registrar")]
        public async Task<ActionResult<RegistroModelView>> Registrar(RegistroModelView registroModelView)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var validador = new RegistroValidation();
            var validationResult = await validador.ValidateAsync(registroModelView);

            if (!validationResult.IsValid)
            {
                return CustomResponse(validationResult);
            }

            var registro = registroModelView.Converta();
            
            await _registroService.Adicione(registro);

            return CustomResponse(registroModelView);
        }

        //Delete
        [HttpDelete("remover/{id:guid}")]
        public async Task<ActionResult> Deletar(Guid id)
        {
            await _registroService.Remove(id);
            return CustomResponse();
        }

        //Put
        [HttpPut("atualizar")]
        public async Task<ActionResult> Atualizar(RegistroModelView registroModelView)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var validador = new RegistroValidation();
            var validationResult = await validador.ValidateAsync(registroModelView);

            if (!validationResult.IsValid)
            {
                return CustomResponse(validationResult);
            }

            var registro = registroModelView.Converta();

            await _registroService.Atualize(registro);

            return CustomResponse(registroModelView);
        }

    }
}
