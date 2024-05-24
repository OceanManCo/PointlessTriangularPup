using System;

class Program {
  public static void Main (string[] args) {
    personalInfo(0);
    personalInfo(1);
    personalInfo(2);
    personalInfo(3);
  }
  public static void personalInfo(int test){//program that will run to print information
 if(test==0){//these tests will be done for each of the required tests and called using the test variable
   Console.WriteLine("Lucinda Potter");
   Console.WriteLine("6/24/1992");
   Console.WriteLine("work 000-000-0101");
   Console.WriteLine("cell 000-000-0189");
   }
   else if(test==1){
   Console.WriteLine("John Smith");
   Console.WriteLine("8/15/1978");
   Console.WriteLine("work 000-111-0101");
   Console.WriteLine("cell 000-111-0189");
   ;
   }
    else if(test==2){
  Console.WriteLine("Chris Johnson");
   Console.WriteLine("12/01/1987");
   Console.WriteLine("work 000-222-0101");
   Console.WriteLine("cell 000-222-0189");
   ;
    }
    else{
   Console.WriteLine("Robert Hall");
   Console.WriteLine("2/27/1949");
   Console.WriteLine("work 000-444-0101");
   Console.WriteLine("cell 000-444-0189");
    }
  }

  }
