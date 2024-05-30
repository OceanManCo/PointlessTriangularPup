using System;

class Program {
  public static void Main (string[] args) {
    inToCm(5);
    inToCm(50);
    inToCm(-15);
    inToCm(15994);
  }
  public static void inToCm(double In){//program that will run to print information
   In=In*2.54;
  Console.WriteLine(In); 
    }
  }

