namespace ApiWebRPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDENES.SolicitanteOrden")]
    public partial class SolicitanteOrden
    {
        [StringLength(50)]
        public string SolicitanteOrdenID { get; set; }

        [StringLength(50)]
        public string Solicitante_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrdenID { get; set; }

        [StringLength(50)]
        public string AreaID { get; set; }

        [StringLength(350)]
        public string Solicitante { get; set; }

        [StringLength(50)]
        public string Naturaleza { get; set; }

        [StringLength(50)]
        public string TipoResidencia { get; set; }

        [StringLength(50)]
        public string TipoID { get; set; }

        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(350)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(150)]
        public string RepresentanteNombre { get; set; }

        [StringLength(20)]
        public string RepresentanteCedula { get; set; }

        [StringLength(50)]
        public string Origen { get; set; }
    }
}
