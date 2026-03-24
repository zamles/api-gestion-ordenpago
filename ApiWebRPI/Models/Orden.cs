namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDENES.Orden")]
    public partial class Orden
    {
        [StringLength(50)]
        public string OrdenID { get; set; }

        [Required]
        [StringLength(50)]
        public string AreaID { get; set; }

        [StringLength(50)]
        public string CategoriaPagoID { get; set; }

        [StringLength(15)]
        public string NoOrden { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(4)]
        public string AnnoOrden { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string SolicitanteID { get; set; }

        public string Observaciones { get; set; }

        [StringLength(50)]
        public string Gestor { get; set; }

        [StringLength(50)]
        public string NoTramite { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public int Estado { get; set; }

        public DateTime? FechaAnulacion { get; set; }

        [StringLength(500)]
        public string ObsAnulacion { get; set; }

        [StringLength(50)]
        public string UsuarioAnula { get; set; }

        public DateTime? FechaReactivacion { get; set; }

        [StringLength(500)]
        public string ObsReactivacion { get; set; }

        [StringLength(50)]
        public string UsuarioReactiva { get; set; }

        [Required]
        [StringLength(50)]
        public string Origen { get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool? Vencida { get; set; }

        public bool? Pagada { get; set; }

        [StringLength(50)]
        public string ComprobanteID { get; set; }

        [StringLength(50)]
        public string Comprobante { get; set; }

        [StringLength(150)]
        public string DocumentoFinal { get; set; }

        public bool? Rechazada { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FormatoID { get; set; }
    }
}
