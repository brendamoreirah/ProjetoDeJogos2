using Microsoft.EntityFrameworkCore;
using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Context
{
    public class ProjetoJogosContext : DbContext
    {
        public ProjetoJogosContext() { }
        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options) : base(options)
        {
        }
        public DbSet<Jogo>? Jogos { get; set; }

        public DbSet<Usuarios>? Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Substitua "Eventos" pelo nome correto do banco de dados
                optionsBuilder.UseSqlServer("Server=NOTE32-S28\\SQLEXPRESS; Database=Jogos; User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}