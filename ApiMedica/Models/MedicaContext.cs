using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiMedica.Models
{
    public class MedicaContext : DbContext
    {
        public MedicaContext() : base("MedicaConnection")
        {
            
        }
        public DbSet <TipoCitas> TipoCitas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}