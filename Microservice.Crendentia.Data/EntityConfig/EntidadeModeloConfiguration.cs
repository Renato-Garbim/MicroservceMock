using Microservice.Credentia.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Crendentia.Data.EntityConfig
{
    public class EntidadeModeloConfiguration : IEntityTypeConfiguration<EntidadeModelo>
    {
        public void Configure(EntityTypeBuilder<EntidadeModelo> builder)
        {
            builder.Property(x => x.EntidadeDescription).HasMaxLength(100);

        }
    }
}
