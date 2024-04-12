using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorWebAssAndServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet]

        public async Task<IActionResult> Get()
        {

            string[] names = {
    "Marko", "Kiko", "Tipo", "Ako", "Jasmin",
    "Ratko", "Matko", "Maja", "Ivana", "Suzana",
    "Bubana", "Markan", "Jozo", "Markovski", "Markos",
    "Anja", "Damir", "Luka", "Nina", "Zoran",
    "Sanja", "Tomislav", "Petra", "Igor", "Marija",
    "Ivan", "Ana", "Marina", "Darko", "Josip",
    "Milan", "Bojan", "Kristina", "Marin", "Ante",
    "Matej", "Elena", "Marica", "Davor", "Mirjana",
    "Jelena", "Stjepan", "Miro", "Vedran", "Andrea",
    "Vedrana", "Nikola", "Tomislava", "Petar", "Martina"
};

            string[] surnames = {
    "Matic2", "Matic", "Matica", "Smith", "Johnson",
    "Williams", "Jones", "Brown", "Davis", "Miller",
    "Wilson", "Moore", "Taylor", "Anderson", "Thomas",
    "Jackson", "White", "Harris", "Martin", "Thompson",
    "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez",
    "Lewis", "Lee", "Walker", "Hall", "Allen",
    "Young", "Hernandez", "King", "Wright", "Lopez",
    "Hill", "Scott", "Green", "Adams", "Baker",
    "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez",
    "Roberts", "Turner", "Phillips", "Campbell", "Parker"
};
            List<Person> people = new List<Person>();
            Random rand = new Random();

            for (int i = 0; i < 15000; i++)
            {
                string name = names[rand.Next(names.Length)];
                string surname = surnames[rand.Next(surnames.Length)];
                people.Add(new Person { Name = name, Surname = surname });
            }
            return Ok(people);
        }
        
    }
}
