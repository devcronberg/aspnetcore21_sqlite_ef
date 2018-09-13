using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore21_sqlite_ef.Models
{
    [Table("person")]
    public class Person
    {
        public int PersonId { get; set; }
        public string Navn { get; set; }
        public bool Aktiv { get; set; }
        public DateTime Fødselsdato { get; set; }
    }
}
