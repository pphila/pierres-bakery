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

    public int CalculatedPastryCost(int pastryQuantity)
    {
      int pastryTotal = 0;

      if(pastryQuantity > 2)
      {
        int remainder = pastryQuantity % 3;
        pastryTotal = (((pastryQuantity - remainder) /3) * 5) + (remainder *2);
      }
      else {
        pastryTotal = pastryQuantity * 2;
      }
      return pastryTotal;
    }
  }
}