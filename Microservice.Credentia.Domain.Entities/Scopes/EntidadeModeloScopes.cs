
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Credentia.Domain.Entities.Scopes
{
    public class EntidadeModeloScopes : AbstractValidator<EntidadeModelo>
    {
        public EntidadeModeloScopes()
        {           
            Include(new TransacaoCampoDescricaoEhValido());

        }

        public bool IsValid(EntidadeModelo obj)
        {
            var result = Validate(obj);

            if (result.IsValid) return true;

            foreach (var failure in result.Errors)
            {
                // futuro handle para captar msgs de erro 
            }
            return false;
        }

        internal class TransacaoCampoDescricaoEhValido : AbstractValidator<EntidadeModelo>
        {
            internal TransacaoCampoDescricaoEhValido()
            {
                const string property = "The field Description ";
                RuleFor(x => x.EntidadeDescription)
                    .NotEmpty().WithMessage($"{property} cannot be empty!")
                    .NotNull().WithMessage($"{property} cannot be null!");
            }
        }
    }
}
