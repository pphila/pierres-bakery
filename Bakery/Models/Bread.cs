using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadQuantity { get; set; }

    public Bread (string breadType, int breadQuantity)
    {
      BreadType = breadType; 
      BreadQuantity = breadQuantity;
    }

    public int CalculatedBreadCost(int breadQuantity)
    {
      int breadTotal = 0;
      
      if(breadQuantity >= 3)
      {
        int qauntityCheck = breadQuantity / 3;
        breadTotal += 10 * qauntityCheck;
        breadQuantity -= (qauntityCheck * 3);
      }
      else
      {
        breadTotal = breadQuantity * 5;
      }
      return breadTotal;
    }
  }
}