using System;
using ControlAuvo.Business.Models;
using Xunit;

namespace ControlAuvo.Tests
{
    public class DescreveEmployee
    {
        [Fact]
        public void Nao_deve_permitir_employee_sem_que_seja_informado_o_nome()
        {
            Assert.Throws<Exception>(() => new Empregado(string.Empty));
        }

        [Fact]
        public void Deve_para_cada_objeto_da_classe_employee_conter_um_identificador_unico()
        {
            var empregadoA = new Empregado("Joao");
            var empregadoB = new Empregado("Maria");

            Assert.True(!empregadoA.Id.Equals(empregadoB.Id));
        }
    }
}
