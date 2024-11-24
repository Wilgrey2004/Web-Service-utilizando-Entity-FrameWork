using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Models.VierModels;
using System;
using System.Net;
using System.Net.Http;
using System.Collections;


namespace WebApplication1.Controllers
{
     
        public class InConteoController : ApiController

        {
                // GET: InConteo
                [HttpGet]
                public IEnumerable<InConteoViews> Listar() {
                        List<InConteoViews> lst = new List<InConteoViews>();

                        using (inventarioEntitie db = new inventarioEntitie())
                        {
                                lst = (from d in db.InConteo where d.estatus == 1
                                       select new InConteoViews {
                                               Id = d.id,
                                               Nombre = d.Nombre,
                                               Catidad = (int)d.cantidad,
                                       }).ToList();
                        }
                        return lst;
                }

                [HttpPost]
                public IHttpActionResult Agregar( IConteoPost obj ) {
                        using (inventarioEntitie db = new inventarioEntitie())
                        {
                                InConteo objeto = new InConteo();
                                objeto.Nombre = obj.Nombre;
                                objeto.cantidad = obj.Cantidad;
                                objeto.estatus = 1;
                                db.InConteo.Add(objeto);
                                db.SaveChanges();
                        }
                        return Ok("Nuevo producto agregado");
                }

                [HttpPut]
                public IHttpActionResult Actualizar( InConteoViews Put ) {

                        using (inventarioEntitie db = new inventarioEntitie())
                        {
                                if (Put.Id == 0)
                                {
                                        return Ok("No se encuentra El susuario Seleccionado");
                                }


                                InConteo inConteo = db.InConteo.FirstOrDefault(sf => sf.id == Put.Id);

                                if (inConteo == null)
                                {
                                        return Ok("No hemos encontrado el reguistro en la base de datos");
                                }

                                inConteo.Nombre = Put.Nombre;
                                inConteo.cantidad = Put.Catidad;
                                inConteo.estatus = 1;
                                db.SaveChanges();
                        }

                        return Ok("Cambio Logrado...");
                }

                [HttpDelete]
                public IHttpActionResult Destroy( InConteoViews InConteoDestroy ) {

                        using (inventarioEntitie db = new inventarioEntitie())
                        {
                                InConteo inConteoDestroy = db.InConteo.FirstOrDefault(f => f.id == InConteoDestroy.Id);

                                if (inConteoDestroy == null) { return Ok("Producto no encontrado."); }

                                inConteoDestroy.estatus = 2;
                                db.SaveChanges();

                        }
                        return Ok("Producto Eliminado");
                }
        }
}