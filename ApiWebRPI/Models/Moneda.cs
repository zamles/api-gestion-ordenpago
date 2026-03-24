namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGOS.Moneda")]
    public partial class Moneda
    {
        [StringLength(50)]
        public string MonedaID { get; set; }

        [Column("Moneda")]
        [Required]
        [StringLength(50)]
        public string Moneda1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Abreviatura { get; set; }

        public DateTime FRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
