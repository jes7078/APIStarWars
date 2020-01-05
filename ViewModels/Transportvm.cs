using System.Collections.Generic;

namespace APIStarWars.ViewModels
{
  public class Transportvm
  {
    public int Id{get;set;}
    public string TransportName{get;set;}
    public string Speed{get;set;}

    public List<Personvm> People {get;set;}=new List<Personvm>();
  }
}