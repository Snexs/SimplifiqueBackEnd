﻿using Microsoft.EntityFrameworkCore;
using Simplifique.Domain;
using Simplifique.Domain.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using Flunt.Notifications;

namespace Simplifique.Infra
{
    public class SimplifiqueContext : IdentityDbContext<ApplicationUser>, IUnitOfWork
    {
        public SimplifiqueContext(DbContextOptions<SimplifiqueContext> options) : base(options)
        {
        }

        public DbSet<Cadastro> Cadastro { get; set; }
        public DbSet<Anunciar> Anunciar { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Anuncio> Anuncio { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Contato> Contato { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
            //    e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            //    property.SetColumnType("varchar(150)");

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(SimplifiqueContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }


        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
