using FluentValidation;

namespace ControlAuvo.API.ModelView.Validations
{
    public class RegistroValidation : AbstractValidator<RegistroModelView>
    {
        public RegistroValidation()
        {
            RuleFor(a => a.Nome)
               .NotEmpty()
               .WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(5, 100)
               .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            //RuleFor(a => a.TipoRegistro)
            //    .NotEmpty()
            //    .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(a => a.Data)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
