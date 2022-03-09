﻿using Microsoft.EntityFrameworkCore;
using TesteArq.Domain.Entity;

namespace TesteArq.Data.Context
{
    public class ProjDbContext : DbContext
    {
        public ProjDbContext(DbContextOptions<ProjDbContext> options) : base(options) { }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Curso>().ToTable("Curso");

        }
    }
}
