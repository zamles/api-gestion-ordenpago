namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDENES.OrdenDetalle")]
    public partial class OrdenDetalle
    {
        [StringLength(50)]
        public string OrdenDetalleID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrdenID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoriaPagoID { get; set; }

        [Required]
        [StringLength(150)]
        public string CategoriaPago { get; set; }

        [Required]
        [StringLength(50)]
        public string ConceptoID { get; set; }

        [Required]
        [StringLength(3500)]
        public string Concepto { get; set; }

        [StringLength(50)]
        public string MonedaID { get; set; }

        [StringLength(50)]
        public string Moneda { get; set; }

        public decimal Monto { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        public DateTime FechaRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
