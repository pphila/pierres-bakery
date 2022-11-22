using System;
using System.Threading;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    static void Main()
    {
      string title = @"
      
 ____ ____    ___  ____   ____     ___ __  _____     ____    ____  __  _    ___  ____   __ __ 
|    \    |  /  _]|    \ |    \   /  _]  |/ ___/    |    \  /    ||  |/ ]  /  _]|    \ |  |  |
|  o  )  |  /  [_ |  D  )|  D  ) /  [_|_ (   \_     |  o  )|  o  ||  ' /  /  [_ |  D  )|  |  |
|   _/|  | |    _]|    / |    / |    _] \|\__  |    |     ||     ||    \ |    _]|    / |  ~  |
|  |  |  | |   [_ |    \ |    \ |   [_    /  \ |    |  O  ||  _  ||     \|   [_ |    \ |___, |
|  |  |  | |     ||  .  \|  .  \|     |   \    |    |     ||  |  ||  .  ||     ||  .  \|     |
|__| |____||_____||__|\_||__|\_||_____|    \___|    |_____||__|__||__|\_||_____||__|\_||____/ 
                                                                                              
";
      Console.WriteLine(title);
      Console.WriteLine("Welcome In!");
      Thread.Sleep(500);
      Console.WriteLine(".");
      Thread.Sleep(500);
      Console.WriteLine("..");
      Thread.Sleep(500);
      Console.WriteLine("...");
      Thread.Sleep(500);
      Console.WriteLine("Here's What Is Freshly Baked Today");
      Thread.Sleep(500);
      Console.WriteLine("We offer breads like sourdough, baguettes, ciabatta, and rye for just $5!");
      Console.WriteLine("And Pastries like kringles, eclairs, fruit danishes, and cannolis for only $2!");
      Thread.Sleep(500);
      Console.WriteLine("_________________________");
      Thread.Sleep(1000);
      Console.WriteLine("Our specials for bread today is buy 2 and get 1 free!");
      Console.WriteLine("And also, our Pastry specials are buy");
      Thread.Sleep(500);
      Console.WriteLine("3 for $5, 4 for $7, 5 for $9, and 6 for $10!");
      Thread.Sleep(500);
      Console.WriteLine("Are your ready to order? [Y or N]");
      
      string startOrder = Console.ReadLine();
      if (startOrder == "Y" || startOrder == "y")
      {
        Console.WriteLine("What kind of bread would you like?");
        string breadTypeAnswer = Console.ReadLine();
        Thread.Sleep(500);
        Console.WriteLine("How many of the " + breadTypeAnswer + " would you like?");
        string quantityBreadAnswer = Console.ReadLine();
        int breadIntQty = int.Parse(quantityBreadAnswer);

        Bread breadOrder = new Bread(breadTypeAnswer, breadIntQty);
        Thread.Sleep(1000);
        
        Console.WriteLine("Okay! and now for Pastries, what kind of pastry would you like?");
        string pastryTypeAnswer = Console.ReadLine();
        Console.WriteLine("And how many " + pastryTypeAnswer + " would you like?");
        string qauntityPastryAnswer = Console.ReadLine();
        int pastryIntQty = int.Parse(qauntityPastryAnswer);

        Pastry pastryOrder = new Pastry(pastryTypeAnswer, pastryIntQty);

        int breadCost = breadOrder.CalculatedBreadCost(breadIntQty);
        int pastryCost = pastryOrder.CalculatedPastryCost(pastryIntQty);
        int totalCost = breadCost + pastryCost;

        Console.WriteLine("________________________________________");
        Thread.Sleep(1500);
        Console.WriteLine("Your total for " + breadTypeAnswer + " is $" + breadCost);
        Console.WriteLine("and the total for your " + pastryTypeAnswer + " is $" + pastryCost);
        Thread.Sleep(500);
        Console.WriteLine("Your total price for your whole order comes to $" + totalCost + "!");
        Thread.Sleep(1000);
        Console.WriteLine("Thank you for coming in! Have a wonderful day.");
      }
    }
  }
}