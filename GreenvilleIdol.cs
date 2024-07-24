using System;
partial class Program {
public static void OnRun(){
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************ \n");//inital setup
    Console.WriteLine("Please Enter the following number below from the following menu:\n");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");
    bool yearsize=false;
    int Response=Int32.Parse(Console.ReadLine());
    if(Response==1){
        Console.WriteLine("How many contestants last year?");
        int lastYear=Int32.Parse(Console.ReadLine());//reads old contestants
        while(lastYear>=30||lastYear<0){
            Console.WriteLine("this is not a valid number please input a number from 1-30");
            lastYear=Int32.Parse(Console.ReadLine());//reads *new* old contestants
            }
        Console.WriteLine("How many contestants this year?");
        int thisYear=Int32.Parse(Console.ReadLine());//reads new contestants
        while(thisYear>=30||thisYear<0){
             Console.WriteLine("this is not a valid number please input a number from 1-30");
            thisYear=Int32.Parse(Console.ReadLine());//reads *new* new contestants
            }
        Console.WriteLine("Last year's competition had "+lastYear+" contestants, and this year's has "+thisYear +" contestants \n Revenue expected this year is $"+thisYear*25 +" ");//calcuates revenue and shows difference
        if(thisYear>lastYear){
            yearsize=true;
            if(lastYear*2-thisYear==0){//checks if size is bigger or lower than half
                Console.WriteLine("the competiton is twice as big!");
            }
            else if(lastYear-thisYear<0){//checks to see if its bigger than half
                Console.WriteLine("The competition is bigger than ever!");
                }

            }
            else{
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
            Console.WriteLine("It is "+yearsize +" that this year's competition is bigger than last year's.");
        
        }
    
    else{
        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }
    }
 }