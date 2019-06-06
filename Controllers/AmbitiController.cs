using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace carichini.alessandro._5i.Corsi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbitiController : ControllerBase
    {
        corsiContex db = new corsiContex();
        // GET api/ambiti
        [HttpGet]
        public ActionResult<IEnumerable<Ambito>> Get()
        {
             return db.ambiti.ToList();
        }

        // GET api/ambiti/5
        [HttpGet("{id}")]
        public ActionResult<Ambito> Get(int id)
        {
            return db.ambiti.Find(id);
        }

        // POST api/ambiti
        [HttpPost]
        public void Post([FromBody] Ambito value)
        {
             if( value != null ){
                db.ambiti.Add( value );
                db.SaveChanges();
            }
        }

        // PUT api/ambiti/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ambito value)
        {
             if( value != null ){
                Ambito b = db.ambiti.Find(id);
                if( b != null)
                {
                    b.Descrizione = value.Descrizione;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/ambiti/5
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
