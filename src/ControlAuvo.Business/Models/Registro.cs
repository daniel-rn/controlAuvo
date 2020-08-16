using System;

namespace ControlAuvo.Business.Models
{
    public class Registro : Entity
    {
        public Registro()
        {
        }

        public Registro(ETipoRegistro tipoRegistro, DateTime data, Employee employee)
        {
            TipoRegistro = tipoRegistro;
            Data = data;

            Employee = employee ?? throw new Exception("Deve ser informado o Employee");
        }

        public DateTime Data { get; set; }

        public ETipoRegistro TipoRegistro { get; }

        public Employee Employee { get; set; }

        public int Tipo { get; set; }
    }
}
