using ControlAuvo.API.ModelView;
using ControlAuvo.Business.Models;

namespace ControlAuvo.API
{
    public static class Extensions
    {
        public static Registro Converta(this RegistroModelView registroModelView)
        {
            var emp = new Empregado(registroModelView.Nome);

            return new Registro(registroModelView.TipoRegistro, registroModelView.Data, emp)
            {
                //EmployeeId = emp.Id,
                Tipo = (int)registroModelView.TipoRegistro
            };
        }
    }
}
