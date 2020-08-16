using System;
using System.ComponentModel.DataAnnotations;
using ControlAuvo.Business.Models;

namespace ControlAuvo.API.ModelView
{
    public class RegistroModelView
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public ETipoRegistro TipoRegistro { get; set; }

        [Required]
        public DateTime Data { get; set; }
    }
}
