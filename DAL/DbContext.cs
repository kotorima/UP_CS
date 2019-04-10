using Microsoft.EntityFrameworkCore;

namespace prC_
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=filmsdb;Uid=root;Pwd=;CharSet=utf8");
        }
    }
}