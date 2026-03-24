namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDENES.ConceptoPago")]
    public partial class ConceptoPago
    {
        [Key]
        [StringLength(50)]
        public string ConceptoID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoriaPagoID { get; set; }

        [Required]
        [StringLength(750)]
        public string Concepto { get; set; }

        [Required]
        [StringLength(50)]
        public string MonedaID { get; set; }

        public decimal Monto { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public bool Estado { get; set; }

        public bool Reservado { get; set; }

        public int TramoControl { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(50)]
        public string UsuarioEdita { get; set; }

        public DateTime? FechaEdita { get; set; }

        [StringLength(5)]
        public string Codigo { get; set; }

        public bool? EsServicio { get; set; }
    }
}
