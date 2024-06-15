using System;
using System.Linq;
class Program {
  public static void Main (string[] args) {
     HomeSales(0,0,0,0);
    }
  public static void HomeSales (int grandtot,int dsale,int esale, int fsale){
    Console.WriteLine("Hello sales repesentive of Holiday Homes! please input your username! Or to end this service type Z");
    
    string user=Console.ReadLine();
    if(user=="D"||user=="d"){
      Console.WriteLine("Hello Danielle! Please input the sale you just made");
      dsale=Int32.Parse(Console.ReadLine());//this will parse the text and make it a number
      grandtot+=dsale;
      HomeSales(grandtot,dsale,esale,fsale);
      }
    else if(user=="E"||user=="e"){
      Console.WriteLine("Hello Edward! Please input the sale you just made");
      esale=Int32.Parse(Console.ReadLine());//this will parse the text and make it a number
      grandtot+=esale;
      HomeSales(grandtot,dsale,esale,fsale);
      }
    else if(user=="F"||user=="f"){
      Console.WriteLine("Hello Francis! Please input the sale you just made");
      fsale=Int32.Parse(Console.ReadLine());//this will parse the text and make it a number
      grandtot+=fsale;
      HomeSales(grandtot,dsale,esale,fsale);
      }
    else if(user=="Z"||user=="z"){
      int[] datlist={dsale,esale,fsale};
      if(datlist.Max()==dsale){
        Console.WriteLine("Highest Sale: D");
      }
      else if(datlist.Max()==esale){
        Console.WriteLine("Highest Sale: E");
      }
      else{
        Console.WriteLine("Highest Sale: F");
      }
      Console.WriteLine("Grand Total: $"+grandtot);
      }
    else{
      Console.WriteLine("that is not a valid responce please try again");
      HomeSales(grandtot,dsale,esale,fsale);
    }
  
    
    }
  }

