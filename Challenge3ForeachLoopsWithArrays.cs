//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public static void Main()
	{
		string[] colors = {"red", "blue", "red", "red", "blue", "blue", "blue", "red", "blue"};
		int red = 0, blue = 0;
		
		foreach (string c in colors)
		{
			Console.Write(c + ", ");
			
			if (c == "blue")
				blue ++;
			else if (c == "red")
				red ++;
		}
		Console.WriteLine("\n");
		Console.WriteLine("The number of reds are {0}", red);
		Console.WriteLine("The number of blues are {0}", blue);
		
		Console.WriteLine("\n");
		if (red > blue)
		{
			Console.WriteLine("The reds outnumber the blues " + red + " to " + blue + ".");
		}
		else if (red < blue)
		{
			Console.WriteLine("The blues outnumber the reds " + blue + " to " + red + ".");
		}
	
		colors[1] = "red";
		colors[4] = "red";
		Console.WriteLine("\n");
		
		red = 0; 
		blue = 0;
		foreach (string c in colors)
		{
			Console.Write(c + ", ");
			
			if (c == "blue")
				blue ++;
			else if (c == "red")
				red ++;
		}
		Console.WriteLine("\n");
		Console.WriteLine("The number of reds are {0}", red);
		Console.WriteLine("The number of blues are {0}", blue);	
		
		Console.WriteLine("\n");
		if (red > blue)
		{
			Console.WriteLine("The reds outnumber the blues " + red + " to " + blue + ".");
		}
		else if (red < blue)
		{
			Console.WriteLine("The blues outnumber the reds " + blue + " to " + red + ".");
		}
	}
}
