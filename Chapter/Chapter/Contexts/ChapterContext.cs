using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
    public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }

        //Vamos utilizar esse metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificacao
                optionsBuilder.UseSqlServer("Data Source = CYBERNOTE-13; initial catalog = Chapter; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serao utilizadas nas operacoes de leitura, criacao, atualizacao e delecao.
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
