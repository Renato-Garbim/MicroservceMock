
using Microservice.Credentia.Domain.Entities;
using Microservice.Crendentia.Data.EntityConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace InfraMiggration
{
    public class MicroserviceCredentiaContext : DbContext
    {
        public MicroserviceCredentiaContext(DbContextOptions<MicroserviceCredentiaContext> options) : base(options)
        {

        }

        public DbSet<EntidadeModelo> EntidadeModelo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null) return;

            // Config das Tabelas via EF

            modelBuilder.ApplyConfiguration(new EntidadeModeloConfiguration());

        }
    }
}
