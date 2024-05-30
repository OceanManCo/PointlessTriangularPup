using System;

class Program {
  public static void Main (string[] args) {
    inToCm();
    inToCm();
    inToCm();
    inToCm();
  }
  public static void inToCm(){//program that will run to print information
   double In=Convert.ToDouble(Console.ReadLine());
    In=In*2.54;
  Console.WriteLine(In); 
    }
  }

