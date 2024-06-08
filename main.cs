using System;

class Program {
  public static void Main (string[] args) {
    hurricane(152);
    hurricane(97.913);
    hurricane(70.55);
    hurricane(175.99);
    }
  public static void hurricane (double Catagory){
    if(Catagory>157){
      Console.WriteLine("Catagory Five hurricane");
    }
    else if(Catagory<156&&Catagory>130){
      Console.WriteLine("Catagory Four hurricane");
    }
    else if(Catagory<129&&Catagory>111){
      Console.WriteLine("Catagory three hurricane");
    }
    else if(Catagory<110&&Catagory>96){
      Console.WriteLine("Catagory two hurricane");
    }
    else if(Catagory<95&&Catagory>74){
    Console.WriteLine("Catagory one hurricane");
    }
    else{
      Console.WriteLine("Not a hurricane");
    }
    }
  }

