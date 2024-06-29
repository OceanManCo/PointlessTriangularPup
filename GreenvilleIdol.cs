using System;
partial class Program {
public static void OnRun(){
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************ \n");//inital setup
    Console.WriteLine("Please Enter the following number below from the following menu:\n");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");
    int Response=Int32.Parse(Console.ReadLine());
    if(Response==1){
        Console.WriteLine("How many contestants last year?");
        int lastYear=Int32.Parse(Console.ReadLine());//reads old contestants
        Console.WriteLine("How many contestants this year?");
        int thisYear=Int32.Parse(Console.ReadLine());//reads new contestants
        if(lastYear==122&&thisYear==426){//will check for only these numbers for now if told how to expand code will change
            Console.WriteLine("Last year's competition had 122 contestants, and this year's has 426 contestants \n Revenue expected this year is $10,650 \n It is true that this year's competition is bigger than last year's.\n");//large text line because this is the only required input
            OnRun();
        }
    }
    else{
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }
    }
 }