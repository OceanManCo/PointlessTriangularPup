using System;

class Program {
  public static void Main (string[] args) {
  Perfect(496);
  Perfect(68);
  Perfect(5112);
  Perfect(8128);
    }
  public static void Perfect (double number){// this will take all numbers from 1-1000 that are perfect
    if(number== 6||number== 28||number== 496||number== 8128){
      Console.WriteLine("Perfect Number");
    }
    else{//this shows the result if not the four perfect numebrs
      Console.WriteLine("Not A Perfect Number");
    }
    }
  }

