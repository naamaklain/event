using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EVENTS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    { 
        public static List<Event> Events = new List<Event> { new Event { ID = 1, Title = "weeding" ,date=new DateTime() } , new Event { ID = 2, Title = "string", date = new DateTime() } };

        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return Events;
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return Events.Find(e=>e.ID==id);
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post([FromBody] Event value)
        {
            Events.Add(value);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event value)
        {
            var index=Events.FindIndex(e=>e.ID==id);
            Events[index].Title = value.Title;
            Events[index].date = value.date;
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e = Events.Find(e => e.ID == id);
            Events.Remove(e);
        }
    }
}
