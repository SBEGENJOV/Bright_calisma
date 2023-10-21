using coreapiproject.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace coreapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SporcularController : ControllerBase
    {
        public readonly ApplicationDbContext Context;
        public SporcularController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        [HttpGet] //api/sporcular
        public IActionResult Index()
        {
            return Ok(Context.Sporculars.ToList());
        }

        [HttpGet("{id}")] //api/sporcular//ıd
        public IActionResult IndexSprId(int id)
        {
            //return Ok(Context.Sporculars.Find(id);
            return Ok(Context.Sporculars.FirstOrDefault(m => m.SporcuID == id));
        }
        [HttpPost]
        public IActionResult AddSpr(Sporcular sporcular)
        {
            Context.Add(sporcular);
            Context.SaveChanges();
            return Created("", sporcular);
        }
        [HttpPut("{id}")]//api/sporcular/1
        public IActionResult UpdateSpr(int id, Sporcular sporcular)
        {
            var result=Context.Sporculars.FirstOrDefault(m=>m.SporcuID == id);
            result.AdSoyad=sporcular.AdSoyad;
            result.Ulke=sporcular.Ulke;
            result.TakimlarID=sporcular.TakimlarID;
            //Context.Update(sporcular);
            Context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSpr(int id)
        {
            var result = Context.Sporculars.FirstOrDefault(m => m.SporcuID == id);
            Context.Remove(result);
            Context.SaveChanges();
            return NoContent();
        }
    }
}
