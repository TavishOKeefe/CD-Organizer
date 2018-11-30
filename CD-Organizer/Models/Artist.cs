using System.Collections.Generic;

namespace Organizer.Models
{
  public class Artist
  {
    private string _description;
    private int _id;
    private static List<Artist> _instances = new List<Artist> {};

    public Artist (string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Artist> GetAll()
  {
    return _instances;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }
  public int GetId()
 {
   return _id;
 }
   public static Artist Find(int searchId)
 {
   return _instances[searchId-1];
 }
}
}
