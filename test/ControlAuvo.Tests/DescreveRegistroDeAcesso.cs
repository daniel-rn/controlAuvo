using System;
using ControlAuvo.Business.Models;
using Xunit;

namespace ControlAuvo.Tests
{

    public class DescreveRegistroDeAcesso
    {

        [Fact]
        public void Deve_possuir_tipo_registro_entrada()
        {
            //Arrange
            //Act
            var employee = new Empregado("Joao");
            var registro = new Registro(ETipoRegistro.Entrada, DateTime.Now, employee);

            //Assert 
            Assert.True(registro.TipoRegistro == ETipoRegistro.Entrada);
        }

        [Fact]
        public void Deve_possuir_tipo_registro_saida()
        {
            //Arrange
            //Act
            var employee = new Empregado("Joao");
            var registro = new Registro(ETipoRegistro.Saida, DateTime.Now, employee);

            //Assert 
            Assert.True(registro.TipoRegistro == ETipoRegistro.Saida);
        }

        [Fact]
        public void Deve_possuir_data_de_saida()
        {
            //Arrange
            //Act
            var employee = new Empregado("Joao");
            var dataRegistro = DateTime.Now;
            var registro = new Registro(ETipoRegistro.Saida, dataRegistro, employee);

            //Assert 
            Assert.True(registro.TipoRegistro == ETipoRegistro.Saida);
            Assert.NotNull(registro.Data);
            Assert.True(Equals(registro.Data, dataRegistro));
        }

        [Fact]
        public void Deve_possuir_data_de_entrada()
        {
            //Arrange
            //Act
            var employee = new Empregado("Joao");
            var dataRegistro = DateTime.Now;
            var registro = new Registro(ETipoRegistro.Entrada, dataRegistro, employee);

            //Assert 
            Assert.True(registro.TipoRegistro == ETipoRegistro.Entrada);
            Assert.NotNull(registro.Data);
            Assert.True(Equals(registro.Data, dataRegistro));
        }

        public void Nao_deve_criar_o_registro_de_entrada_caso_nao_seja_informado_o_employee()
        {
            Assert.Throws<Exception>((Func<object>)(() => (object)new Registro(ETipoRegistro.Entrada, DateTime.Now, null)));
        }

        public void Nao_deve_criar_o_registro_de_saida_caso_nao_seja_informado_o_employee()
        {
            Assert.Throws<Exception>(() => new Registro(ETipoRegistro.Entrada, DateTime.Now, null));
        }
    }
}
