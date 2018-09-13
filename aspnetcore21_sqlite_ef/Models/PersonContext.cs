using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore21_sqlite_ef.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Personer { get; set; }

        public PersonContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=c:\\temp\\aspnetcore21_sqlite_ef\\aspnetcore21_sqlite_ef\\personer.db");
            optionsBuilder.UseSqlite("Data Source=personer.db");
        }
    }
}

