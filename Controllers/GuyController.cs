using Microsoft.AspNetCore.Mvc;
using ProjectApi.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuyController : ControllerBase
    {
        List<Guy> guys = new List<Guy>()
        {
            new Guy(){Name="Asher",Id=1,Age=19,Heigh=1.75,Yeshiva="Bet-Mates",Sector="yeoodi"},
            new Guy(){Name="haim",Id=2,Age=23,Heigh=1.70,Yeshiva="Bet-Ell",Sector="litvish"},
            new Guy(){Name="Eli",Id=3,Age=14,Heigh=1.60,Yeshiva="Mishcenot",Sector="yeoodi"},
        };
        // GET: api/<GuyController>
        [HttpGet]
        public IEnumerable<Guy> Get()
        {
            return guys;
        }

        // GET api/<GuyController>/5
        [HttpGet("{id}")]
        public IEnumerable<Guy> Get(int id)
        {
            return guys.Where(x=>x.Id==id);
        }
        [HttpGet("{age}")]
        public IEnumerable<Guy> GetAge(int age)
        {
            return guys.Where(x => x.Age == age);
        }

        // POST api/<GuyController>
        [HttpPost]
        public void Post([FromBody] Guy value)
        {
            guys.Add(value);
        }

        // PUT api/<GuyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guy value)
        {
           int index= guys.FindIndex(x => x.Id == id);
            guys[index] = value;
        }

        // DELETE api/<GuyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guys.Remove(guys.Find(x => x.Id == id));
        }
    }
}
