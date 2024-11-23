using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Models.VierModels;


namespace WebApplication1.Controllers
{


        public class InConteoController : ApiController

        {
                // GET: InConteo
                [System.Web.Http.HttpGet]
                public IHttpActionResult Get() {
                        List<InConteoViews> lst = new List<InConteoViews>();

                        using (inventarioEntitie db = new inventarioEntitie())
                        {
                                lst = (from d in db.InConteo
                                       select new InConteoViews {
                                               Id = d.id,
                                               Nombre = d.Nombre,
                                               Catidad = (int)d.cantidad,
                                       }).ToList();
                        }
                        return Ok(lst);
                }

                [System.Web.Http.HttpPost]
                public IHttpActionResult Post( IConteoPost obj ) {
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

                [System.Web.Http.HttpPut]
                public IHttpActionResult Put( InConteoViews Put ) {

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

                public IHttpActionResult Destroy(int id) {

                        using (inventarioEntitie db = new inventarioEntitie())
                        {
                                InConteo inConteoDestroy = db.InConteo.FirstOrDefault(f => f.id == id);

                                if (inConteoDestroy == null) { return Ok("Producto no encontrado."); }
                                
                                inConteoDestroy.estatus = 2;
                                db.SaveChanges();

                        }
                        return Ok("Producto Eliminado");
                }
        }
}