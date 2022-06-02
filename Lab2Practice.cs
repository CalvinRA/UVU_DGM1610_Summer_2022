//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public Operations operate;
	public Status status;
	
	public void Main()
	{
		operate = new Operations();
		status = new Status();
		
		Console.WriteLine("Begin program.");
		
		operate.Add(4, 9);
		operate.Add(11, 51);
		operate.Subtract(9, 4);
		operate.Subtract(48, 19);
		operate.Examin(7, 4);
		operate.Examin(91, 52);
		operate.Examin(4, 5);
		operate.Examin(12, 37);
		operate.Examin(5, 5);
		operate.Examin(62, 62);
		
		status.currentState = Status.States.Solid;
		status.CheckState();
		
		status.currentState = Status.States.Gas;
		status.CheckState();
		
		status.currentState = Status.States.Liquid;
		status.CheckState();
	}
	
}

public class Operations
{
	public void Add(int valueOne, int valueTwo)
	{
		var number = valueOne + valueTwo;
		
		Console.WriteLine(number);
	}
	
	public void Subtract(int valueOne, int valueTwo)
	{
		var number = valueOne - valueTwo;
		
		Console.WriteLine(number);
	}
	
	public void Examin(int valueOne, int valueTwo)
	{
		if(valueOne > valueTwo)
		{
			Console.WriteLine(valueOne + " is greater than " + valueTwo + ".");
		}
		else if(valueTwo > valueOne)
		{
			Console.WriteLine(valueTwo + " is greater than " + valueOne + ".");
		}
		else
		{
			Console.WriteLine(valueOne + " and " + valueTwo + " are equal.");
		}
		
	}
	
	public void IDCheack(string iD)
	{
		if(iD == "John117")
		{
			Console.WriteLine("Welcom Master Cheif.");
		}
		else
		{
			Console.WriteLine("Unauthorized Personnel.");
		}
	}
	
}

public class Status
{
	public enum States
	{
		Solid,
		Liquid,
		Gas
	}
	
	public States currentState = States.Solid;
	
	public void CheckState ()
	{
		switch (currentState)
		{
			case States.Solid:
				Console.WriteLine("Solid.");
				break;
			case States.Liquid:
				Console.WriteLine("Liquid.");
				break;
			case States.Gas:
				Console.WriteLine("Gas.");
				break;
		}
	}
	
}
