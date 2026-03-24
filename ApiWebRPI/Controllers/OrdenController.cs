using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ApiWebRPI.Models;

namespace ApiWebRPI.Controllers
{
    public class OrdenController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        [Route("api/Orden/Numero/{id}")]
        [HttpGet]
        public string GetNumero(string id)
        {
            HttpContext context = HttpContext.Current;
            using (var db = new ModeloSACI())
            {
                var orden = db.Orden.FirstOrDefault(f => f.OrdenID == id);                
                return orden.NoOrden;
            }                               
        }

        // POST api/<controller>
        [Route("api/Orden")]
        [HttpPost]
        public void PostOrden([FromBody] SACICabezera objeto)
        {
            HttpContext context = HttpContext.Current;

            var newOrden = new Orden()
            {
                OrdenID = objeto.OrdenID,
                AreaID = objeto.AreaID,
                CategoriaPagoID = objeto.CategoriaPagoID,
                Fecha = objeto.Fecha,
                SolicitanteID = objeto.SolicitanteID,
                Observaciones = objeto.Observaciones,
                Usuario = objeto.Usuario,
                Estado = objeto.EstadoOrden,
                Origen = objeto.OrigenOrden,
                Gestor = objeto.Gestor,
                NoTramite = objeto.NoTramite,
                FechaRegistro = objeto.FechaRegistro,
                Vencida = false,
                Pagada = false,
                FormatoID= "0B28F052-4586-40FD-8AF8-3DB8C45B2E5F"
            };
            var newBitacora = new OrdenBitacora()
            {
                BitacoraID = Guid.NewGuid().ToString(),
                Tabla = "ORDENES.Orden",
                ReferenciaID = objeto.OrdenID,
                Accion = "Generada",
                Descripcion = "Registro Orden de Pago",
                FechaRegistro = DateTime.Now,
                Usuario = objeto.Usuario
            };

            var solicitante = objeto.Solicitante;
            var newSolicitante = new SolicitanteOrden()
            {
                SolicitanteOrdenID = solicitante.SolicitanteID,
                OrdenID = solicitante.OrdenID,
                AreaID = solicitante.AreaID,
                Solicitante = solicitante.Solicitante,
                Naturaleza = solicitante.Naturaleza,
                TipoResidencia = solicitante.TipoResidencia,
                TipoID = solicitante.TipoID,
                Identificacion = solicitante.Identificacion,
                Direccion = solicitante.Direccion,
                Telefono = solicitante.Telefono,
                RepresentanteNombre = solicitante.Representante,
                RepresentanteCedula = solicitante.Cedula
            };
            var listaOrdenDetalle = new List<OrdenDetalle>();
            var detalleOrden = objeto.Detalle;


            using (var db = new ModeloSACI())
            {
                using (DbContextTransaction trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var area = db.Areas.FirstOrDefault(f => f.Area.Equals(newOrden.AreaID));
                        newOrden.AreaID = area.AreaID;
                        var categoriaPago = db.CategoriaPago.FirstOrDefault(f=>f.NombreCategoria.Equals(newOrden.CategoriaPagoID));
                        newOrden.CategoriaPagoID = categoriaPago.CategoriaPagoID;


                        db.SolicitanteOrden.Add(newSolicitante);
                        db.Orden.Add(newOrden);
                        db.OrdenBitacora.Add(newBitacora);

                        foreach (var item in detalleOrden)
                        {
                            var conceptoPago = db.ConceptoPago.FirstOrDefault(f => f.Codigo.Equals(item.Codigo));
                            var moneda = db.Moneda.FirstOrDefault(f => f.MonedaID == conceptoPago.MonedaID);
                            var catagoriaPago = db.CategoriaPago.FirstOrDefault(f => f.CategoriaPagoID == conceptoPago.CategoriaPagoID);
                            decimal total = item.Cantidad * conceptoPago.Monto;

                            var newOrdenDetalle = new OrdenDetalle()
                            {
                                OrdenDetalleID = Guid.NewGuid().ToString(),
                                OrdenID = item.OrdenID,
                                CategoriaPagoID = catagoriaPago.CategoriaPagoID,
                                CategoriaPago = catagoriaPago.NombreCategoria,
                                ConceptoID = conceptoPago.ConceptoID,
                                Concepto = conceptoPago.Concepto,
                                MonedaID = moneda.MonedaID,
                                Moneda = moneda.Moneda1,
                                Monto = conceptoPago.Monto,
                                Cantidad = item.Cantidad,
                                Total = total,
                                FechaRegistro = item.FechaRegistro,
                                Usuario = item.Usuario
                            };

                            db.OrdenDetalle.Add(newOrdenDetalle);

                            if(item.Parametro == 1)
                            {
                                decimal totalCalculo50 = (total * 50) / 100;

                                var newOrdenDetalle50 = new OrdenDetalle()
                                {
                                    OrdenDetalleID = Guid.NewGuid().ToString(),
                                    OrdenID = item.OrdenID,
                                    CategoriaPagoID = catagoriaPago.CategoriaPagoID,
                                    CategoriaPago = catagoriaPago.NombreCategoria,
                                    ConceptoID = conceptoPago.ConceptoID,
                                    Concepto = "50% DE RECARGO",
                                    MonedaID = moneda.MonedaID,
                                    Moneda = moneda.Moneda1,
                                    Monto = conceptoPago.Monto,
                                    Cantidad = item.Cantidad,
                                    Total = totalCalculo50,
                                    FechaRegistro = item.FechaRegistro,
                                    Usuario = item.Usuario
                                };
                                db.OrdenDetalle.Add(newOrdenDetalle50);
                            }
                            if (item.Parametro == 2)
                            {
                                decimal totalCalculo100 = (total * 100) / 100;

                                var newOrdenDetalle100 = new OrdenDetalle()
                                {
                                    OrdenDetalleID = Guid.NewGuid().ToString(),
                                    OrdenID = item.OrdenID,
                                    CategoriaPagoID = catagoriaPago.CategoriaPagoID,
                                    CategoriaPago = catagoriaPago.NombreCategoria,
                                    ConceptoID = conceptoPago.ConceptoID,
                                    Concepto = "100% DE RECARGO",
                                    MonedaID = moneda.MonedaID,
                                    Moneda = moneda.Moneda1,
                                    Monto = conceptoPago.Monto,
                                    Cantidad = item.Cantidad,
                                    Total = totalCalculo100,
                                    FechaRegistro = item.FechaRegistro,
                                    Usuario = item.Usuario
                                };
                                db.OrdenDetalle.Add(newOrdenDetalle100);
                            }
                        }

                        db.SaveChanges();

                        trans.Commit();
                        context.Response.StatusCode = 200;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        context.Response.StatusCode = 500;
                    }
                    finally
                    {
                        // Termina la respuesta para evitar procesar más contenido
                        context.Response.End();
                    }
                }
            }

        }

        [Route("api/Orden/Usuario")]
        [HttpPost]
        public void PostUsuario([FromBody] SACIPersona objeto)
        {
            HttpContext context = HttpContext.Current;

            var newPersona = new Personas()
            {
                PersonaID = Guid.NewGuid().ToString(),
                PrimerNombre = objeto.PrimerNombre,
                SegundoNombre = objeto.SegundoNombre,
                PrimerApellido = objeto.PrimerApellido,
                SegundoApellido = objeto.SegundoApellido,
                NombreCompleto = objeto.NombreCompleto,
                Telefono = objeto.Telefono,
                TipoID = "15CCF50A-CBDA-45A9-802C-47D7D926B69D",
                NumeroID = objeto.NumeroID,
                Direccion = objeto.Direccion,
                DepartamentoID = objeto.DepartamentoID,
                MunicipioID = objeto.MunicipioID,
                CorreoElectronico = objeto.CorreoElectronico,
                FechaRegistro = DateTime.Now
            };
            var usuario = objeto.Usuario;

            var newUsuario = new UsuariosGestion()
            {
                UsuarioID = usuario.UsuarioID,
                PersonaID = newPersona.PersonaID,
                Usuario = usuario.Usuario,
                Clave = usuario.Clave,
                Estado = true,
                Confirmado = true,
                FechaRegistro = DateTime.Now
            };

            using (var db = new ModeloSACI())
            {
                using (DbContextTransaction trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Personas.Add(newPersona);
                        db.UsuariosGestion.Add(newUsuario);
                        db.SaveChanges();
                        trans.Commit();

                        context.Response.StatusCode = 200;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        context.Response.StatusCode = 500;
                    }
                    finally
                    {
                        // Termina la respuesta para evitar procesar más contenido
                        context.Response.End();
                    }
                }
            }

        }
       
        [Route("api/Orden/Solicitud")]
        [HttpPost]
        public void PostSolicitud([FromBody] SACISolicitud objeto )
        {
            HttpContext context = HttpContext.Current;

            var newSolicitud = new Solicitud()
            {
                GestionSolicitudID = objeto.GestionSolicitudID,
                OrdenID = objeto.OrdenID,
                AreaID = "58D87B36-CCD4-49EF-A386-9C88CB1E178E",
                NoOrden = objeto.NoOrden,
                ComprobanteID = "Pendiente",
                NoComprobante = "Pendiente",
                Estado = objeto.Estado,
                FechaRegistro = objeto.FechaRegistro,
                UsuarioID = objeto.UsuarioID,
                Transaccion = objeto.CodigoGestion,
                Asignada = false
                
            };
            var pago = objeto.Pago;
            var newPago = new Pago()
            {
                PagoID = Guid.NewGuid().ToString(),
                GestionSolicitudID = pago.GestionSolicitudID,
                NoTransaccion = pago.NoTransaccion,
                Fecha = pago.Fecha,
                Documento = pago.Documento,
                ContentType = pago.ContentType,
                NombreDocumento = pago.NombreDocumento,
                FechaRegistro = pago.FechaRegistro
            };

            using (var db = new ModeloSACI())
            {

                using (DbContextTransaction trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Solicitud.Add(newSolicitud);
                        db.Pago.Add(newPago);

                        db.SaveChanges();
                        trans.Commit();

                        context.Response.StatusCode = 200;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        context.Response.StatusCode = 500;
                    }
                    finally
                    {
                        // Termina la respuesta para evitar procesar más contenido
                        context.Response.End();
                    }
                }                
            }

        }


        // PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}