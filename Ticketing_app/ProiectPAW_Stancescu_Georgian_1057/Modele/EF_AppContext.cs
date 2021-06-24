using Microsoft.EntityFrameworkCore;
using ProiectPAW_Stancescu_Georgian_1057.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Stancescu_Georgian_1057.Modele
{
    public class EF_AppContext: DbContext
    {
        public EF_AppContext()
        {
            try
            {
                Database.Migrate();
            }
            catch(Exception)
            {
                Console.WriteLine("Tabelele din baza de date reflecta structura claselor de C#.");
            }
        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Solutie> Solutii { get; set; }
        public DbSet<Programator> Programatori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=bugs.db");
        }
    }
}
