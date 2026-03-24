namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATALOGOS.Areas")]
    public partial class Areas
    {
        [Key]
        [StringLength(50)]
        public string AreaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public bool Estado { get; set; }

        public bool? Mostrar { get; set; }

        [StringLength(50)]
        public string DireccionID { get; set; }
    }
}
