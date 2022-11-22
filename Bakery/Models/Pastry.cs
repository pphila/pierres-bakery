using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public string PastryType { get; set; }
    public int PastryQuantity { get; set; }

    public Pastry (string pastryType, int pastryQuantity)
    {
      PastryType = pastryType;
      PastryQuantity = pastryQuantity;
    }
  }
}