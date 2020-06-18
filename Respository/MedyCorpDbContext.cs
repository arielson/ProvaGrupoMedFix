using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Repository
{
    public class MedyCorpDbContext : DbContext
    {
        public MedyCorpDbContext()
        {
        }

        public MedyCorpDbContext(DbContextOptions<MedyCorpDbContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}