namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GESTION.Solicitud")]
    public partial class Solicitud
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string GestionSolicitudID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string OrdenID { get; set; }

        [StringLength(50)]
        public string AreaID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NoOrden { get; set; }

        [StringLength(50)]
        public string ComprobanteID { get; set; }

        [StringLength(50)]
        public string NoComprobante { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaComprobante { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Estado { get; set; }

        public bool? Asignada { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FechaRegistro { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string UsuarioID { get; set; }

        [StringLength(50)]
        public string Transaccion { get; set; }

        public DateTime? FechaAnulacion { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        [StringLength(50)]
        public string UsuarioAnula { get; set; }
    }
}
