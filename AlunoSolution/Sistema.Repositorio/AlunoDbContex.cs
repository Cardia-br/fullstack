using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Sistema.Repositorio
{
    public class AlunoDbContext : DbContext
    {
        public AlunoDbContext(DbContextOptions<AlunoDbContext> options)
        : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}

