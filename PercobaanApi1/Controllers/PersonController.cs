using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;

namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }
        [HttpGet("api/person/{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            PersonContext mycontext = new PersonContext();
            var person = mycontext.ListPerson().FirstOrDefault(p => p.id_person == id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }
    }
}