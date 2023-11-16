using Microsoft.AspNetCore.Mvc;
using ProjectApi.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchmakerController : ControllerBase
    {
        List<Matchmaker> matchmaker = new List<Matchmaker>()
        {
            new Matchmaker(){Name="Rachel",Id=1,ExperienceYear=5},
            new Matchmaker(){Name="Bracha",Id=2,ExperienceYear=15},
            new Matchmaker(){Name="Nechama",Id=3,ExperienceYear=20},
        };
        // GET: api/<MatchmakerController>
        [HttpGet]
        public IEnumerable<Matchmaker> Get()
        {
            return matchmaker;
        }

        // GET api/<MatchmakerController>/5
        [HttpGet("{id}")]
        public IEnumerable<Matchmaker> Get(int id)
        {
            return matchmaker.Where(x => x.Id == id);
        }
       // [HttpGet("{ExperienceYear}")]
        //public IEnumerable<Girl> GetAge(int experienceYear)
        //{
          //  return matchmaker.Where(x => x.ExperienceYear>=GetAge());
        //}
        // POST api/<MatchmakerController>
        [HttpPost]
        public void Post([FromBody] Matchmaker value)
        {
            matchmaker.Add(value);
        }

        // PUT api/<MatchmakerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Matchmaker value)
        {
            int index = matchmaker.FindIndex(x => x.Id == id);
            matchmaker[index] = value;
        }

        // DELETE api/<MatchmakerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            matchmaker.Remove(matchmaker.Find(x => x.Id == id));
        }
    }
}
