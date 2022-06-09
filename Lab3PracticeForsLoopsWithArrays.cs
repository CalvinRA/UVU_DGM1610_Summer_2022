//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public void Main()
	{
		
		for(int i = 0; i <= 7; i++)
		{
			Console.WriteLine(i);
		}
		
		for(int i = 8; i >= 4; i = i - 2)
		{
			Console.WriteLine(i);
		}
		
		string[] gear = {"Helmet", "Gloves", "Boots", "Armor", "Weapon"};
		Console.WriteLine(gear.Length);
		for(int inven = 0; inven < gear.Length; inven++)
		{
			Console.WriteLine(gear[inven]);
		}

//Not sure how to convert a dowhile loop into a for loop.		
//		do
//		{
//			Console.WriteLine(i);
//			i = i * 3;
//		}
//		while(i >= 10);
		
//		Console.WriteLine(i);
	}
}
