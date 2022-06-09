//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public static void Main()
	{
		string[] materials = {"Wood", "Fabric", "Herbs", "Flint", "Rope", "Potatoes"};
		foreach(string i in materials)
		{
			Console.WriteLine(i);
		}
		
		int[] numbers = {10, 12, 17, 21, 25, 32, 40};
		numbers[4] = 26;
		
		foreach(int i in numbers)
		{
			Console.WriteLine(i);
		}
	}
}
