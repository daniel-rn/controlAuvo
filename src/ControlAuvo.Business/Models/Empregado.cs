using System;
using System.Collections.Generic;

namespace ControlAuvo.Business.Models
{
    public class Empregado : Entity
    {
        public Empregado(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Deve ser informado o nome");
            }

            Nome = nome;
        }

        public string Nome { get; set; }

        public IEnumerable<Registro> Registros { get; set; }
    }

}
