using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiWebRPI.Models
{
    public class SACIPersona
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }        
        public string NumeroID { get; set; }
        public string Direccion { get; set; }
        public string DepartamentoID { get; set; }
        public string MunicipioID { get; set; }
        public string CorreoElectronico { get; set; }
        public SACIUsuario Usuario { get; set; }
    }
    public class SACIUsuario
    {
        public string UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}