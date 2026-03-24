namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDENES.OrdenBitacora")]
    public partial class OrdenBitacora
    {
        [Key]
        [StringLength(50)]
        public string BitacoraID { get; set; }

        [Required]
        [StringLength(50)]
        public string Tabla { get; set; }

        [Required]
        [StringLength(50)]
        public string ReferenciaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Accion { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
