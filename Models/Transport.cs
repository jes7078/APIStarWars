namespace APIStarWars.Models
{
  public class Transport
  {
    public int Id{get;set;}
    public string TransportName{get;set;}
    public string Speed{get;set}

    public People People {get;set;}
  }
}