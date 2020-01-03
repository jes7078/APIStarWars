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
    var prevPerson=db.People.FirstOrDefault(pe => pe.Id == person.Id);
    if(prevStudent==null)
    {
      return NotFound();
    }
    else
    {
      prevPerson.Name=person.Name;
      prevPerson.Force=person.Force;
      prevPerson.PrimaryWeapon=person.PrimaryWeapon;
      db.SaveChanges();
      return Ok(prevPerson);
    }
  }


  }
}