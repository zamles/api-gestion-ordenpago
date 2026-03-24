using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWebRPI.Controllers
{
    public class OrdenPagoController : ApiController
    {        
        //PUT api/OrdenPago/Revision/id        
        [Route("api/OrdenPago/Revision/{id}")]
        [HttpPut]
        public void PutRevision(Guid id, [FromBody] string[] value)
        {
            using (var db = new Models.ModeloRPI())
            {
                var objeto = db.OrdenPago.FirstOrDefault(f => f.IdOrdenPago == id);

                if (objeto != null)
                {
                    objeto.Revisado = value[0] == "1";
                    objeto.NumeroOrdenPago = value[1];

                    db.SaveChanges();
                }
                else
                {                    
                    throw new Exception("Orden de pago no encontrada");
                }
            }
        }


        //PUT api/OrdenPago/Pago/id        
        [Route("api/OrdenPago/Pago/{id}")]
        [HttpPut]
        public void PutPago(Guid id, [FromBody] string value)
        {
            using (var db = new Models.ModeloRPI())
            {
                var objeto = db.OrdenPago.FirstOrDefault(f => f.IdOrdenPago == id);

                if (objeto != null)
                {
                    objeto.Pagado = value == "1";

                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Orden de pago no encontrada");
                }
            }
        }


    }
}