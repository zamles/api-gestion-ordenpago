namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.UsuariosGestion")]
    public partial class UsuariosGestion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UsuarioID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PersonaID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Clave { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Estado { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Confirmado { get; set; }

        [StringLength(4)]
        public string Codigo { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaRegistro { get; set; }

        public DateTime? UltimoAcceso { get; set; }
    }
}
