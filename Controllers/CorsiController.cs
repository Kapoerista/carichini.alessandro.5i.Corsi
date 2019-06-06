using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace carichini.alessandro._5i.Corsi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorsiController : ControllerBase
    {
        corsiContex db = new corsiContex();
        // GET api/corsi
        [HttpGet]
        public ActionResult<IEnumerable<Corso>> Get()
        {
            return db.corsi.ToList();
        }

        // GET api/corsi/5
        [HttpGet("{id}")]
        public ActionResult<Corso> Get(int id)
        {
            return db.corsi.Find(id);
        }

        // POST api/corsi
        [HttpPost]
        public void Post([FromBody] Corso value)
        {
            if( value != null ){
                db.corsi.Add( value );
                db.SaveChanges();
            }
        }

        // PUT api/corsi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Corso value)
        {
            if( value != null ){
                Corso b = db.corsi.Find(id);
                if( b != null)
                {
                    b.Prezzo = value.Prezzo;
                    b.NumeroLezioni = value.NumeroLezioni;
                    b.NumeroMaxPartecipanti = value.NumeroMaxPartecipanti;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/corsi/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Corso b = db.corsi.Find(id);
            if( b != null)
            {
                db.corsi.Remove(b);
                db.SaveChanges();
            }
        }
    }
}
