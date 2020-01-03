using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIStarWars.Models
{
  public class Person
  {
    public int Id {get;set;}
    public string Name {get;set;}
    public string Force {get;set;}
    public string PrimaryWeapon {get;set;}
  }
}