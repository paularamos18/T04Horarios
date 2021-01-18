using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace T04Horarios.Models
{
    public class PeliculasDBConnections:DbContext
    {
        public PeliculasDBConnections(): base("PeliculasBd")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Peliculas> Peliculas { get; set; }
    }
}