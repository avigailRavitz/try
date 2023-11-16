using Microsoft.AspNetCore.Mvc;
using ProjectApi.Classes;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GirlController : ControllerBase
    {
        List<Girl> girls = new List<Girl>()
        {
            new Girl(){Name="Chani",Id=1,Age=20,Heigh=1.68,Seminary="Wolf",Sector="litvish"},
            new Girl(){Name="Avigail",Id=2,Age=19,Heigh=2.00,Seminary="Wolf",Sector="litvish"},
            new Girl(){Name="Diti",Id=3,Age=19,Heigh=1.59,Seminary="Lostig",Sector="yeoodi"},
        };
        // GET: api/<GirlController>
        [HttpGet]
        public List<Girl> Get()
        {
            return girls;
        }
        [HttpGet("{age}")]
        public IEnumerable<Girl> GetAge(int age)
        {
            return girls.Where(x => x.Age == age);
        }

        // GET api/<GirlController>/5
        [HttpGet("{id}")]
        public IEnumerable< Girl> Get(int id)
        {
            return girls.Where(x=>x.Id==id);
        }

        // POST api/<GirlController>
        [HttpPost]
        public void Post([FromBody] Girl girl)
        {
            girls.Add(girl);
        }

        // PUT api/<GirlController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Girl girl)
        {
           int index = girls.FindIndex(x => x.Id == id);
            girls[index] = girl;
        }

        // DELETE api/<GirlController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            girls.Remove(girls.Find(x => x.Id == id));
        }
    }
}
