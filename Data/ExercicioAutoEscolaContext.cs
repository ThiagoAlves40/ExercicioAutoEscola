using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExercicioAutoEscola.Pages.Aluno;
using ExercicioAutoEscola.Pages.Recepcao;
using ExercicioAutoEscola.Pages.Instrutor;
using ExercicioAutoEscola.Pages.Contato;

namespace ExercicioAutoEscola.Data
{
    public class ExercicioAutoEscolaContext : DbContext
    {

        public ExercicioAutoEscolaContext (DbContextOptions<ExercicioAutoEscolaContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = ARADSK273\SQLEXPRESS; Initial Catalog=BDAutoEscola; Integrated Security = true");
        }
        public DbSet<ExercicioAutoEscola.Pages.Aluno.Aluno> Aluno { get; set; }

        public DbSet<ExercicioAutoEscola.Pages.Recepcao.Recepcao> Recepcao { get; set; }

        public DbSet<ExercicioAutoEscola.Pages.Instrutor.Instrutor> Instrutor { get; set; }

        public DbSet<ExercicioAutoEscola.Pages.Contato.Contato> Contato { get; set; }
    }
}
