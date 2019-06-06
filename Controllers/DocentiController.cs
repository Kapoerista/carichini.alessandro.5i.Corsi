using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace carichini.alessandro._5i.Corsi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentiController : ControllerBase
    {
        corsiContex db = new corsiContex();
        // GET api/docenti
        [HttpGet]
        public ActionResult<IEnumerable<Docente>> Get()
        {
            return db.docenti.ToList();
        }

        // GET api/docenti/5
        [HttpGet("{id}")]
        public ActionResult<Docente> Get(int id)
        {
            return db.docenti.Find(id);
        }

        // POST api/docenti
        [HttpPost]
        public void Post([FromBody] Docente value)
        {
             if( value != null ){
                db.docenti.Add( value );
                db.SaveChanges();
            }
        }

        // PUT api/docenti/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Docente value)
        {
            if( value != null ){
                Docente b = db.docenti.Find(id);
                if( b != null)
                {
                    b.Nome = value.Nome;
                    b.Cognome = value.Cognome;
                    b.DataNascita = value.DataNascita;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/docenti/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             Docente b = db.docenti.Find(id);
            if( b != null)
            {
                db.docenti.Remove(b);
                db.SaveChanges();
            }
        }
    }
}
