//DGM 1610 Calvin Ambrose

using System;

//Based on the HelloWorld File, turn this into a class.

public class Program
{
	public Car carOne;
	public Car carTwo;
	public Car carThree;
	public Car carFour;
	
	public void Main()
	{
		carOne = new Car();
		carTwo = new Car();
		carThree = new Car();
		carFour = new Car();
		
		carOne.type = "smart";
		carOne.color = "black";
		carOne.speed = "slow";
		carOne.noise = "quiet";
		
		carTwo.type = "compact";
		carTwo.color = "red";
		carTwo.speed = "fast";
		carTwo.noise = "moderate";
		
		carThree.type = "truck";
		carThree.color = "blue";
		carThree.speed = "decent";
		carThree.noise = "loud";
		
		carFour.type = "suv";
		carFour.color = "grey";
		carFour.speed = "decent";
		carFour.noise = "moderate";
		
		Console.WriteLine("Car One");
		Console.WriteLine(carOne.type);
		Console.WriteLine(carOne.color);
		Console.WriteLine(carOne.speed);
		Console.WriteLine(carOne.noise + "\n");
		
		Console.WriteLine("Car Two");
		Console.WriteLine(carTwo.type);
		Console.WriteLine(carTwo.color);
		Console.WriteLine(carTwo.speed);
		Console.WriteLine(carTwo.noise + "\n");
		
		Console.WriteLine("Car Three");
		Console.WriteLine(carThree.type);
		Console.WriteLine(carThree.color);
		Console.WriteLine(carThree.speed);
		Console.WriteLine(carThree.noise + "\n");
		
		Console.WriteLine("Car Four");
		Console.WriteLine(carFour.type);
		Console.WriteLine(carFour.color);
		Console.WriteLine(carFour.speed);
		Console.WriteLine(carFour.noise + "\n");
	}
}
//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
public class Car
{
	public string type;
	public string color;
	public string speed;
	public string noise;
}
