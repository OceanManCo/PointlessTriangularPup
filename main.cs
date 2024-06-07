using System;

class Program {
  public static void Main (string[] args) {
    CheckLength("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas.");
    CheckLength("Massa vitae tortor condimentum lacinia quis vel eros donec ac.");
    CheckLength("Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.");
    }
  public static void CheckLength(string message){
    int messLen=message.Length;
    int Accepted=messLen-140;
    if(Accepted>0){
      Console.WriteLine("Rejected");
      }
      else{
      Console.WriteLine("Posted");
      }
    
    }
  }

