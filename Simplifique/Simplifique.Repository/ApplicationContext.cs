using Microsoft.EntityFrameworkCore;
using Simplifique.Domain;

namespace Simplifique.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>().HasKey(c => c.IdCategoria);

            modelBuilder.Entity<Cadastro>().HasKey(cd => cd.IdUsuario);

            modelBuilder.Entity<Anunciar>().HasKey(a => a.IdAnuncio);
            modelBuilder.Entity<Anunciar>().HasOne(an => an.Anunciante);
            modelBuilder.Entity<Anunciar>().HasOne(c => c.Categoria);

            modelBuilder.Entity<Anuncio>().HasKey(a => a.IdAnuncio);
            modelBuilder.Entity<Anuncio>().HasOne(a => a.IdAnunciar);

            modelBuilder.Entity<Contato>().HasOne(a => a.IdAnunciar);
        }
    }
}
