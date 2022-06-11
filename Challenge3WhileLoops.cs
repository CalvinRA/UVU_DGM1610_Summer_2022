//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public static void Main()
	{
		int i = 0;
		
		while(true)
		{
			Console.WriteLine("i = " + i);
			i++;
				if(i > 9)
				break;
		}
		
		int x = 0;
		int y = 0;
		
		while(x < 3)
		{
			y = 0;
			Console.WriteLine("x = " + x);
		
			while(y <= x)
			{
				Console.WriteLine("y = " + y);
				y++;
				
			}
			x++;
		}
	}
}
