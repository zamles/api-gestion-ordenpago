namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDENES.CategoriaPago")]
    public partial class CategoriaPago
    {
        [StringLength(50)]
        public string CategoriaPagoID { get; set; }

        [Required]
        [StringLength(50)]
        public string AreaID { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreCategoria { get; set; }

        public bool Estado { get; set; }

        [StringLength(50)]
        public string MonedaID { get; set; }

        public DateTime FechaRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
