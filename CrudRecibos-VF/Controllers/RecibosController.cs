using CrudRecibos_VF.Context;
using CrudRecibos_VF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudRecibos_VF.Controllers
{
    [Route("api/[controller]")]
    
    public class RecibosController : Controller
    {
        private readonly AppReciboContext context;
        public RecibosController(AppReciboContext context)
        {
            this.context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Recibos.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}", Name = "GetRecibo")]
        public ActionResult Get(int id)
        {
            try
            {
                var recibo = context.Recibos.FirstOrDefault(g => g.Id == id);
                return Ok(recibo);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Recibos recibo)
        {
            try
            {
                context.Recibos.Add(recibo);
                context.SaveChanges();
                return CreatedAtRoute("GetRecibo", new { id = recibo.Id }, recibo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Recibos recibo)
        {
            try
            {
                if (recibo.Id == id)
                {
                    context.Entry(recibo).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetRecibo", new { id = recibo.Id }, recibo);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var recibo = context.Recibos.FirstOrDefault(g => g.Id == id);
                if (recibo != null)
                {
                    context.Recibos.Remove(recibo);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
