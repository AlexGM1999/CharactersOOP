using Microsoft.EntityFrameworkCore;

namespace CharactersOOP.Models
{
    public class CharacterContext: DbContext
    {
        public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CharactersDB;Trusted_Connection=True;");
        }
    }
}
