using System;

namespace ControlAuvo.Business.Models
{
    public class Registro : Entity
    {
        public Registro()
        {
        }

        public Registro(ETipoRegistro tipoRegistro, DateTime data, Empregado empregado)
        {
            TipoRegistro = tipoRegistro;
            Data = data;

            Empregado = empregado ?? throw new Exception("Deve ser informado o Empregado");
        }

        public DateTime Data { get; set; }

        public ETipoRegistro TipoRegistro { get; }

        public Empregado Empregado { get; set; }

        public int Tipo { get; set; }
    }
}
