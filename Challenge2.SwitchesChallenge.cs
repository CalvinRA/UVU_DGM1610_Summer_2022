//DGM 1610 Calvin Ambrose
using System;
// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.	
public class Program
{
	public ChangePower power;
	public AdjustPower status;
	
	public void Main()
	{
		power = new ChangePower();
		status = new AdjustPower();
		
		Console.WriteLine("Determining power.");
		
		power.AddPower(2, 31);
		power.AddPower(14, 3);
		
		power.RemovePower(8, 7);
		power.RemovePower(27, 11);
		
		power.CompairPower(17, 6);
		power.CompairPower(15, 32);
		power.CompairPower(4, 4);
		
		power.CheckPower("buffed");
		power.CheckPower("debuffed");
		power.CheckPower("power");
		
		Console.WriteLine(status.GetAdjustment(2));
		Console.WriteLine(status.GetAdjustment(5));
		Console.WriteLine(status.GetAdjustment(1));
		Console.WriteLine(status.GetAdjustment(3));
		Console.WriteLine(status.GetAdjustment(6));

	}
}

public class ChangePower
{
	public void AddPower(int valueOne, int valueTwo)
	{
		var number = valueOne + valueTwo;
		
		Console.WriteLine(number);
	}	
	
	public void RemovePower(int valueOne, int valueTwo)
	{
		var number = valueOne - valueTwo;
		
		Console.WriteLine(number);
	}
	
		public void CompairPower(int valueOne, int valueTwo)
	{
		if(valueOne > valueTwo)
		{
			Console.WriteLine("Power level " + valueOne + " is greater than power level " + valueTwo + ".");
		}
		else if(valueTwo > valueOne)
		{
			Console.WriteLine("Power level " + valueTwo + " is greater than power level " + valueOne + ".");
		}
		else
		{
			Console.WriteLine("Power level " + valueOne + " and power level " + valueTwo + " are equal.");
		}
		
	}
		
	public void CheckPower(string current)
	{
		if(current == "buffed")
		{
			Console.WriteLine("You have increased power.");
		}
		else if(current == "debuffed")
		{
			Console.WriteLine("You have reduced power.");
		}
		else
		{
			Console.WriteLine("You have normal power.");
		}
	}
}

public class AdjustPower
{
	public string GetAdjustment(int changePlayer)
	{
		string changeMake;
		
		switch(changePlayer)
		{
			case 0:
				changeMake = "Improve damage";
				break;
			case 1:
				changeMake = "Improve speed";
				break;
			case 2:
				changeMake = "Improve health";
				break;
			case 3:
				changeMake = "Weaken damage";
				break;
			case 4:
				changeMake = "Weaken speed";
				break;
			case 5:
				changeMake = "Weaken health";
				break;
			default:
				changeMake = "No change to any powers";
				break;
		}
		
		return changeMake;
	}
}
