using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIStarWars.Models;

namespace APIStarWars.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TransportController : ControllerBase
  {
    
      [HttpGet]
    public ActionResult GetAllTransports()
    {
      var db= new DatabaseContext();
      return Ok(db.Transports.OrderBy(Transport=>Transport.TransportName));
    }

    [HttpGet("{id}")]
    public ActionResult GetOneTransport(int id)
    {
      var db= new DatabaseContext();
      var transport=db.Transports.Include(i=>i.People).FirstOrDefault(Tr=>Tr.Id==id);
      if (transport==null)
      {
        return NotFound();
      }
      else
      {
        var rv=new Personvm
        {
          Id = Transport.Id,
          Name = Transport.TransportName,
          Speed = Transport.Speed,
          People = Person.People.Select(pr=>new Personvm
          {
           Id=pr.Id,
           Name=pr.Name,
           Force=pr.Force,
           PrimaryWeapon=pr.PrimaryWeapon
           }).ToLIst()
        };
      return Ok(rv);
    }
    }
   

 [HttpPost]
  public ActionResult CreateTransport(Transport transport)
  {
    var db=new DatabaseContext();
    transport.Id=0;
    
    db.Transports.Add(transport);
    db.SaveChanges();
    return Ok(transport);
  }
[HttpPut("{id}")]
public ActionResult UpdateTransport(Transport transport)
{
  var db=new DatabaseContext();
  var prevTransport=db.Transports.FirstOrDefault(tr=>tr.Id==transport.Id);
  if (prevTransport == null)
  {
    return NotFound();
  }
  else 
  {
    prevTransport.TransportName=transport.TransportName;
    prevTransport.Speed=transport.Speed;
    db.SaveChanges();
    return Ok(prevTransport);
  }
}

[HttpDelete("{id}")]
public ActionResult DeleteTransport(int id)
{
  var db= new DatabaseContext();
  var transport=db.Transports.FirstOrDefault(tr=>tr.Id==id);
  if (transport==null)
  {
    return NotFound();
  }
  else
  {
    db.Transports.Remove(transport);
    db.SaveChanges();
    return Ok();
  }
}

  }
}

