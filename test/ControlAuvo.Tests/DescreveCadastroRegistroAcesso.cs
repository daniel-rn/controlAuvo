using System;
using ControlAuvo.Business.Interfaces;
using ControlAuvo.Business.Interfaces.repositories;
using ControlAuvo.Business.Interfaces.services;
using ControlAuvo.Business.Models;
using ControlAuvo.Business.Services;
using Moq;
using Xunit;

namespace ControlAuvo.Tests
{
    public class DescreveCadastroRegistroAcesso
    {
        /// <summary>
        /// A intenção destes testes é garantir que por exemplo ao consumir o registro de serviço
        /// o fluxo de execução sempre passe pelos metodos corretos
        /// </summary>

        [Fact]
        public void Servico_deve_adicionar_registro_de_acesso()
        {
            var employee = new Empregado("Joao");
            var entrada = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            var mock = new Mock<IRegistroService>();
            var servico = mock.Object;

            servico.Adicione(entrada);
            
            mock.Verify(m => m.Adicione(entrada), Times.Once);
        }

        [Fact]
        public void Servico_deve_atualizar_registro_de_acesso()
        {
            var employee = new Empregado("Joao");
            var entrada = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            var serviceMock = new Mock<IRegistroService>();
            
            var servico = serviceMock.Object;

            servico.Atualize(entrada);

            serviceMock.Verify(m => m.Atualize(entrada), Times.Once);
        }

        [Fact]
        public void Servico_deve_remover_registro_de_acesso()
        {
            var employee = new Empregado("Joao");
            var entrada = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            var mock = new Mock<IRegistroService>();
            var servico = mock.Object;

            servico.Remove(entrada.Id);

            mock.Verify(m => m.Remove(entrada.Id), Times.Once);
        }

        [Fact]
        public void Servico_deve_obter_todos_registro_de_acesso()
        {
            var mock = new Mock<IRegistroService>();
            var servico = mock.Object;

            servico.ObterTodos();

            mock.Verify(m => m.ObterTodos(), Times.Once);
        }

        [Fact]
        public void Servico_deve_obter_registro_de_acesso_por_id()
        {
            var mock = new Mock<IRegistroService>();
            var servico = mock.Object;

            var id = Guid.NewGuid();

            servico.Consultar(id);

            mock.Verify(m => m.Consultar(id), Times.Once);
        }


        [Fact]
        public void Servico_deve_adicionar_registro_de_acesso_garantindo_a_passagem_pelo_repository()
        {
            var employee = new Empregado("Joao");
            var entrada = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            var mockRepository = new Mock<IRegistroRepository>();
            var mockNotificador = new Mock<INotifier>();

            var servico = new RegistroService(mockNotificador.Object, mockRepository.Object);

            servico.Adicione(entrada);

            mockRepository.Verify(m => m.Adicionar(entrada), Times.Once);
        }

        [Fact]
        public void Servico_deve_atualizar_registro_de_acesso_garantindo_a_passagem_pelo_repository()
        {
            var employee = new Empregado("Joao");
            var entrada = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            var mockRepository = new Mock<IRegistroRepository>();
            var mockNotificador = new Mock<INotifier>();

            var servico = new RegistroService(mockNotificador.Object, mockRepository.Object);

            servico.Atualize(entrada);

            mockRepository.Verify(m => m.Atualizar(entrada), Times.Once);
        }

        [Fact]
        public void Servico_deve_remover_registro_de_acesso_garantindo_a_passagem_pelo_repository()
        {
            var employee = new Empregado("Joao");
            var entrada = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            var mockRepository = new Mock<IRegistroRepository>();
            var mockNotificador = new Mock<INotifier>();

            var servico = new RegistroService(mockNotificador.Object, mockRepository.Object);

            servico.Remove(entrada.Id);

            mockRepository.Verify(m => m.Remover(entrada.Id), Times.Once);
        }

        [Fact]
        public void Servico_deve_obter_todos_registro_de_acesso_garantindo_a_passagem_pelo_repository()
        {
            var mockRepository = new Mock<IRegistroRepository>();
            var mockNotificador = new Mock<INotifier>();

            var servico = new RegistroService(mockNotificador.Object, mockRepository.Object);

            servico.ObterTodos();

            mockRepository.Verify(m => m.ObterTodos(), Times.Once);
        }

        [Fact]
        public void Servico_deve_obter_registro_de_acesso_por_id_garantindo_a_passagem_pelo_repository()
        {
            var mockRepository = new Mock<IRegistroRepository>();
            var mockNotificador = new Mock<INotifier>();

            var servico = new RegistroService(mockNotificador.Object, mockRepository.Object);

            var id = Guid.NewGuid();

            servico.Consultar(id);

            mockRepository.Verify(m => m.ObterPorId(id), Times.Once);
        }
    }
}
