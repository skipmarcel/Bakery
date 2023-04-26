using System;
using Bakery.Models;
using Bakery.UserInterfaceModels;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
     Console.WriteLine("                  ");
     Console.WriteLine("             ~*** WELCOME TO ***~");
     string welcomeBanner = WelcomeBanner.Welcome;
     Console.WriteLine(welcomeBanner);
     Console.WriteLine("                  ");
     Console.WriteLine("Our bread loaves are $5 - Buy 2 get 1 free!");
     Console.WriteLine("Our fruit pastries are $2 - Buy 3 get 1 free!");
     Console.WriteLine("                  ");
     Console.WriteLine("How many loaves of bread  would you like?");
     string breadCount = Console.ReadLine(); 
     int totalLoaves = int.Parse(breadCount);
     BreadDeal deal = new BreadDeal(5.0m, totalLoaves);
     decimal totalPrice = deal.GetTotalPrice();
     Console.WriteLine($"Total price: ${totalPrice:F2}"); 
    }

   
  }
}
    
    


