using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HistorijaController : ControllerBase
    {

        bazaContext db = new bazaContext();

       
        // GET api/<HistorijaController>/5
        [HttpGet]
        public IActionResult historijaPoJmbg(string jmbg)
        {
            List<VwHistorija> historija = db.VwHistorijas.Where(x => x.Jmbg.Equals(jmbg)).ToList();
            return Ok(historija);
        }

        [HttpPost]
        public IActionResult unesiDijagnozu([FromBody] HistorijaBolesti podaci)
        {
            db.Add(podaci);// fino spakovat objekat na frontu
            db.SaveChanges();

            return Ok(podaci);
        }

    }
}
