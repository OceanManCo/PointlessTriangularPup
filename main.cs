using System;
class Program {
  public static void Main (string[] args) {
    TemperaturesComparison();
    }
  public static void TemperaturesComparison(){
    int j=1;
    int great=0;
    int less=0;
    double totalavg=0;
    int[] Tempurature={0,0,0,0,0};
    for(int i=0;i<5;i++){
    int tempnum=Int32.Parse(Console.ReadLine());
      if(tempnum<=130&&tempnum>=-30){
        Tempurature[i]=tempnum;
        totalavg+=tempnum;
        }
      else{
        while(tempnum>130||tempnum<=-30){
          Console.WriteLine("Please input an in range value");
          tempnum=Int32.Parse(Console.ReadLine());
           }
          Tempurature[i]=tempnum;
          totalavg+=tempnum;
        }
      }
      for(int i=0;i<4;i++){
      if(Tempurature[i]<Tempurature[j]){
        great++;
        j++;
      }
        else if(Tempurature[i]>Tempurature[j]){
          less++;
          j++;
        } 
        else{
          j++;
        }
    }
  if(great==4){
    Console.WriteLine("Getting warmer");
  }
    else if(less==4){
      Console.WriteLine("Getting cooler");
    }
    else{
      Console.WriteLine("It’s a mixed bag");
    }
  Console.WriteLine("Average:"+(totalavg/5));
    for(int i=0;i<Tempurature.Length;i++)
    {
    Console.WriteLine(Tempurature[i]);
    }
    }
 }