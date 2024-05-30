using System;

class Program {
  public static void Main (string[] args) {
    costOfMove(10,600);
    costOfMove(6.77,15);
    costOfMove(56.25,325);
    costOfMove(103,3000);
  }
  public static void costOfMove(double hours, double miles){//program that will run to print information
  double cost=200+(hours*150)+(miles*2);
  Console.WriteLine("$"+cost); 
    }
  }

