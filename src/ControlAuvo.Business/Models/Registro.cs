using System;
using System.Collections.Generic;

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

        //public Guid EmployeeId { get; set; }

        //Ef relations
        public Employee Employee { get; set; }
        public int Tipo { get; set; }
    }

    public enum ETipoRegistro
    {
        Entrada,
        Saida
    }

    public class Employee : Entity
    {
        public Employee(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Deve ser informado o nome");
            }

            Nome = nome;
        }

        public string Nome { get; set; }

        //Ef Relations
        public IEnumerable<Registro> Registros { get; set; }
    }

}
