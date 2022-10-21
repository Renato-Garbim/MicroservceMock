using Domain.Utilities.Entities.CrossCutting;
using Microservice.Credentia.Domain.Entities.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Credentia.Domain.Entities
{
    public class EntidadeModelo : EntityBase
    {
        //Os sets sempre privados para evitar que ocorra alteração de dados em baixo nivel.

        public int Id { get; private set; }

        public string EntidadeDescription { get; private set; }


        // Sempre bom um construtor que indica o minimo necessário para se criar uma nova instancia do objeto, assim evitamos que exista quebra na consistência de dados.

        public EntidadeModelo(int id, string entidadeDescription)
        {
            Id = id;
            EntidadeDescription = entidadeDescription;  
        }

        public override bool IsValid()
        {
            var scopeValidation = new EntidadeModeloScopes();
            
            return scopeValidation.IsValid(this);
        }


    }
}
