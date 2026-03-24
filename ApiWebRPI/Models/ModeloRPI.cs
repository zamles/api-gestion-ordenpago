using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ApiWebRPI.Models
{
    public partial class ModeloRPI : DbContext
    {
        public ModeloRPI()
            : base("name=ModeloRPI")
        {
        }

        public virtual DbSet<OrdenPago> OrdenPago { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
