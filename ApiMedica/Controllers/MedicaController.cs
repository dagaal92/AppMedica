using ApiMedica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMedica.Controllers
{
    public class MedicaController : ApiController
    {
        [HttpGet]
        public IEnumerable<TipoCitas> Get()
        {
            using (var context = new MedicaContext())
            {
                return context.TipoCitas.ToList();
            }
        }

        [HttpGet]
        public TipoCitas Get(int id)
        {
            using (var context = new MedicaContext())
            {
                return context.TipoCitas.FirstOrDefault(x=> x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(TipoCitas TipoCitas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        using (var context = new MedicaContext())
            {
                context.TipoCitas.Add(TipoCitas);
                context.SaveChanges();
                return Ok(TipoCitas);
            }

        }

        [HttpPut]
        public TipoCitas Put(TipoCitas TipoCitas)
        {
            using (var context = new MedicaContext())
            {
                var TipoCitasAct = context.TipoCitas.FirstOrDefault(x => x.Id == TipoCitas.Id);
                TipoCitasAct.Cantidad = TipoCitas.Cantidad;
                TipoCitasAct.Descripcion = TipoCitas.Descripcion;
                TipoCitasAct.Imagen = TipoCitas.Imagen;
                TipoCitasAct.Nombre = TipoCitas.Nombre;

                context.SaveChanges();
                return TipoCitas;
            }

        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new MedicaContext())
            {
                var TipoCitasDel = context.TipoCitas.FirstOrDefault(x => x.Id == id);
                context.TipoCitas.Remove(TipoCitasDel);
                context.SaveChanges();
                return true;
            }

        }
    }
}
