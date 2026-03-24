namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SEGURIDAD.Personas")]
    public partial class Personas
    {
        [Key]
        [StringLength(50)]
        public string PersonaID { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerNombre { get; set; }

        [StringLength(50)]
        public string SegundoNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; }

        [StringLength(50)]
        public string SegundoApellido { get; set; }

        [Required]
        [StringLength(150)]
        public string NombreCompleto { get; set; }

        [Required]
        [StringLength(8)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoID { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroID { get; set; }

        [Required]
        [StringLength(350)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        public string DepartamentoID { get; set; }

        [Required]
        [StringLength(50)]
        public string MunicipioID { get; set; }

        [Required]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
