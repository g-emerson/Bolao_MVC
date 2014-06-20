using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bolao_MVC.Models
{
    public class Contexto : DbContext
    {
        public DbSet <Selecao> Selecoes { get; set; }
        public DbSet <Grupo> Grupos { get; set; }
        public DbSet <Jogo> Jogos { get; set; }


        public Contexto()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }
    }

}