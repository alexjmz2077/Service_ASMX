using ProyectoRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoRest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Models.Persona> Get()
        {
            IEnumerable<Models.Persona> lst;
            using (Models.DB_ProyectoEntities db= new Models.DB_ProyectoEntities())
            {
                lst = db.Persona.ToList();
            }
            
            return lst;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] Models.Persona persona)
        {
            if (persona == null)
            {
                return BadRequest("Datos inválidos");
            }

            using (Models.DB_ProyectoEntities db = new Models.DB_ProyectoEntities())
            {
                db.Persona.Add(persona);
                db.SaveChanges();
            }

            return Ok();
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] Models.Persona persona)
        {
            if (persona == null)
            {
                return BadRequest("Datos inválidos");
            }

            using (Models.DB_ProyectoEntities db = new Models.DB_ProyectoEntities())
            {
                Models.Persona existingPersona = db.Persona.FirstOrDefault(p => p.IdUsuario == id);
                if (existingPersona != null)
                {
                    
                    existingPersona.Nombre = persona.Nombre;
                    existingPersona.Apellido = persona.Apellido;
                    existingPersona.FechaNacimiento = persona.FechaNacimiento;
                    existingPersona.Telefono = persona.Telefono;
                    existingPersona.Email = persona.Email;

                    db.SaveChanges();
                }
            }

            return Ok();
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            using (Models.DB_ProyectoEntities db = new Models.DB_ProyectoEntities())
            {
                Models.Persona persona = db.Persona.FirstOrDefault(p => p.IdUsuario == id);
                if (persona != null)
                {
                    db.Persona.Remove(persona);
                    db.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
