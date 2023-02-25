using System.Runtime.Versioning;
using System.Security.Principal;

class Student
{
  public int ID { get; set; }
  public string Name { get; set; }
  public int grade { get; set; }
  public string address { get; set; }
}

class gen
{
  public Random getId { get; set; } = new Random();
  public Random getGrade { get; set; } = new Random();
  public int genId()
  {
    int result = getId.Next(16000000, 22999999);
    return result;
  }
  public int genGrade()
  {
    int result = getGrade.Next(0, 10);
    return result;
  }

}