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
    var tr=db.Transports.FirstOrDefault(tra=>tra.TransportName==person.TransportName);
    person.TransportId=tr.Id;
    db.People.Add(person);
    db.SaveChanges();
    return Ok(person);
  }
[HttpPut("{id}")]
public ActionResult UpdatePerson(Person person)
{
  var db=new DatabaseContext();
  var prevPerson=db.People.FirstOrDefault(pe=>pe.Id==person.Id);
  if (prevPerson == null)
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

[HttpDelete("{id}")]
public ActionResult DeletePerson(int id)
{
  var db= new DatabaseContext();
  var person=db.People.FirstOrDefault(pe=>pe.Id==id);
  if (person==null)
  {
    return NotFound();
  }
  else
  {
    db.People.Remove(person);
    db.SaveChanges();
    return Ok();
  }
}

  }
}