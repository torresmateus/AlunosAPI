using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Fernando",
                    Email = "laranja@gmail.com",
                    Idade = 24
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Roberto",
                    Email = "capivara@gmail.com",
                    Idade = 30
                }
                );
        }
    }
}
