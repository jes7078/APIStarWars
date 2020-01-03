namespace APIStarWars.Models
{
  public class Person
  {
    public int Id {get;set;}
    public string Name {get;set;}
    public string Force {get;set;}
    public string PrimaryWeapon {get;set;}
    public string TransportName {get;set;}
    public int TransportId{get;set;}

    public Transport Transport {get;set;}
  }
}