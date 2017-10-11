using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _city;
    private string _country;
    private int _year;
    private static List<Place> _instances = new List<Place> {};

    //this is the constructor
    public Place (string city, string country, int year)
    {
      _city = city;
      _country = country;
      _year = year;
    }


    public string GetCity()
    {
      return _city;
    }

    public string GetCountry()
    {
      return _country;
    }

    public int GetYear()
    {
      return _year;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
