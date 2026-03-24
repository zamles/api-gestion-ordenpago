namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rpi.OrdenPago")]
    public partial class OrdenPago
    {
        [Key]
        public Guid IdOrdenPago { get; set; }

        [Required]
        [StringLength(150)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroOrdenPago { get; set; }

        public DateTime FechaRegistro { get; set; }

        public Guid IdReferencia { get; set; }

        public Guid IdUsuario { get; set; }

        public bool Pagado { get; set; }

        [StringLength(50)]
        public string ReferenciaBancaria { get; set; }

        public bool? Revisado { get; set; }

        [StringLength(300)]
        public string titulo { get; set; }

        [StringLength(300)]
        public string titular { get; set; }

        [StringLength(50)]
        public string NoSolicitudComprobante { get; set; }
    }
}
