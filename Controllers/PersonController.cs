using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIStarWars.Models;

namespace APIStarWars.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PersonController:ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllPeople()
    {
      var db= new DatabaseContext();
      return Ok(db.People.OrderBy(Person=>Person.Name));
    }

  [HttpPost]
  public ActionResult CreatePerson(Person person)
  {
    var db=new DatabaseContext();
    person.Id=0;
    db.People.Add(person);
    db.SaveChanges();
    return Ok(person);
  }


  }
}