using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIStarWars.Models
{
  public class Transport
  {
    public int Id{get;set;}
    public string TransportName{get;set;}
    public string Speed{get;set;}

    public List<Person> People {get;set;} = new List<Person>();
  }
}