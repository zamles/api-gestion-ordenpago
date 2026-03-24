namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GESTION.Pago")]
    public partial class Pago
    {
        [StringLength(50)]
        public string PagoID { get; set; }

        [Required]
        [StringLength(50)]
        public string GestionSolicitudID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string NoTransaccion { get; set; }

        [Required]
        public byte[] Documento { get; set; }

        [Required]
        [StringLength(50)]
        public string ContentType { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreDocumento { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
