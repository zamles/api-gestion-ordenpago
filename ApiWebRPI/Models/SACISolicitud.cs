using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiWebRPI.Models
{
    public class SACISolicitud
    {
        public string GestionSolicitudID { get; set; }
        public string OrdenID { get; set; }
        public string NoOrden { get; set; }
        public int Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodigoGestion { get; set; }
        public string UsuarioID { get; set; }
        public SACIPago Pago { get; set; }
    }

    public class SACIPago
    {
        public string GestionSolicitudID { get; set; }
        public string NoTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Documento { get; set; }
        public string ContentType { get; set; }
        public string NombreDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
    }


}