using System.Collections.Generic;

namespace Organizer.Models
{
  public class CD
  {
    private static List<CD> _instances = new List<CD>{};
    private string _title;


    public CD(string title)
    {
      _title = title;
      _instances.Add(this);
    }

    public string GetTitle()
    {
      return _title;
    }
  }
}
