using System.Collections.Generic;
using System.Linq;

namespace Parcels.Models
{
  public class Parcel
  {
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }
    public int Distance { get; set; }
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (string name, int width, int height, int length, int weight, int distance)
    {
      Name = name;
      Width = width;
      Height = height;
      Length = length;
      Weight = weight;
      Distance = distance;
      _instances.Add(this);
    }

    public int Volume()
    {
      return Width * Height * Length;
    }

    // distance has to be in miles
    // weight has to be in lbs
    // volume needs to be in cube ft
    public int CostToShip()
    {
      int calculatedCost = CalcShip();
      if (Distance < 30 && calculatedCost < 5)
      {
        return 5;
      }
      return calculatedCost;
    }

    private int CalcShip()
    {
      return Distance * Weight * Volume();
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
