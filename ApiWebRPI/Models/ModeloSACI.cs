using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ApiWebRPI.Models
{
    public partial class ModeloSACI : DbContext
    {
        public ModeloSACI()
            : base("name=ModeloSACI")
        {
        }

        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<CategoriaPago> CategoriaPago { get; set; }
        public virtual DbSet<ConceptoPago> ConceptoPago { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<OrdenBitacora> OrdenBitacora { get; set; }
        public virtual DbSet<OrdenDetalle> OrdenDetalle { get; set; }
        public virtual DbSet<SolicitanteOrden> SolicitanteOrden { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<UsuariosGestion> UsuariosGestion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
