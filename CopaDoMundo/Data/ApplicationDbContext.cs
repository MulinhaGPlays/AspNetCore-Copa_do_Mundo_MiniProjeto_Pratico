using Copa_do_Mundo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CopaDoMundo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AreaModel> Areas { get; set; }
        public DbSet<TorcedorModel> Torcedores { get; set; }
        public DbSet<AlocacaoModel> Alocados { get; set; }
    }
}