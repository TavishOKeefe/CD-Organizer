using System.Collections.Generic;

namespace Organizer.Models
{
  public class CD
  {
    private static List<CD> _instances = new List<CD>{};
    private string _title;
    private int _id;
    private List<Artist> _artists;


    public CD(string title)
    {
      _title = title;
      _instances.Add(this);
      _id = _instances.Count;
      _artists = new List<Artist>{};
    }

    public string GetTitle()
    {
      return _title;
    }
    public int GetId()
    {
      return _id;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<CD> GetAll()
    {
      // To make this test fail first create a blank list of CDs like below
      // List<CD> fakeCd = new List<CD> {};
      // Then return the name of the new list. If the test is asserting two lists have equal values and you return an empty list, the test will fail
      // return fakeCd;
      return _instances;
    }
    public static CD Find(int searchID)
    {
      return _instances[searchID - 1];
    }
    public List<Artist> GetArtist()
    {
      return _artists;
    }
    public void AddArtist(Artist artist)
    {
      _artists.Add(artist);
    }


  }
}
