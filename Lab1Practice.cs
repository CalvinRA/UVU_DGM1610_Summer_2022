using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    	Console.WriteLine("I'm not to sure how much is needed for this");
        
      string name = "Calvin";
      string time = "4:30";
      
      Console.WriteLine(name);
      Console.WriteLine(time);
      
      Console.WriteLine("My name is " + name + ". It is " + time +".");
      
      time = "5:10";
      
      Console.WriteLine("It is now "+ time + ".");
      
     	int firstNum = 45;
        int secondNum = 15;
        
        Console.WriteLine(firstNum);
        Console.WriteLine(secondNum);
        Console.WriteLine(firstNum + secondNum);
        Console.WriteLine(firstNum * secondNum);
     	Console.WriteLine(firstNum / secondNum);
 
     }
  }
}
