using Microsoft.EntityFrameworkCore;
using MVCEntity.Models;

namespace MVCEntity.MySQLDbContext
{
    public class MySQLContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Tipo> Tipos { get; set; } 

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
    }
}
