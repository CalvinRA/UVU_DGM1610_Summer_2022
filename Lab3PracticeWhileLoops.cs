//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public void Main()
	{
		int i = 1;
		
		while(i <= 7)
		{
			Console.WriteLine(i);
			i++;
		}
		
		while(i >= 4)
		{
			Console.WriteLine(i);
			i = i - 2;
		}
		
		do
		{
			Console.WriteLine(i);
			i = i * 3;
		}
		while(i >= 10);
		
		Console.WriteLine(i);
	}
}
