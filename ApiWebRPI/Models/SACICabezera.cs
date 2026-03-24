using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiWebRPI.Models
{
    public class SACICabezera
    {
        public string OrdenID { get; set; }
        public string AreaID { get; set; }
        public string CategoriaPagoID { get; set; }
        public DateTime Fecha { get; set; }
        public string SolicitanteID { get; set; }
        public string Observaciones { get; set; }
        public string Gestor { get; set; }
        public string NoTramite { get; set; }
        public string Usuario { get; set; }
        public int EstadoOrden { get; set; }
        public string OrigenOrden { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Vencida { get; set; }
        public bool Pagada { get; set; }
        
        public SACISolicitante Solicitante { get; set; }

        public List<SACIDetalle> Detalle { get; set; }
    }

    public class SACIDetalle
    {
        public string OrdenID { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Usuario { get; set; }
        public int Parametro { get; set; }

    }

    public class SACISolicitante
    {
        public string SolicitanteID { get; set; }
        public string OrdenID { get; set; }
        public string AreaID { get; set; }
        public string Solicitante { get; set; }
        public string Naturaleza { get; set; }
        public string TipoResidencia { get; set; }
        public string TipoID { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string OrigenSolicitante { get; set; }
        public string Representante { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Usuario { get; set; }

    }

}