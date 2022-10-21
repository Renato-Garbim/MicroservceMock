using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Credentia.DTO
{
    public class EntidadeModeloDTO
    {
        // As properties tem de ser espelhadas da Entidade, não sendo colocado apenas os virtual ( FK )
        public int Id { get;  set; }

        public string EntidadeDescription { get; set; }

    }
}
