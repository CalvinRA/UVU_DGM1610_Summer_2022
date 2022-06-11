//DGM 1610 Calvin Ambrose
using System;
					
public class Program
{
	public static void Main()
	{
		for(int a = 0; a < 6; a++)
		{
			Console.Write(" a = " + a);

			for(int b = 0; b <= a; b++)
			{
				Console.Write(" b = " + b);
			}
			
			Console.WriteLine("\n");
		}
		
		int[] numb = {2, 4, 8, 16, 32, 64};		
		for(int x = 0; x < numb.Length; x++)
		{
			Console.Write(numb[x] + " ");
			
			for(int y = 0; y <= x; y++)
			{
				numb[x] = numb[x] + numb[x];
				Console.Write(numb[x] + " ");
			}
			
			numb[x] = numb[x] / 2;
			Console.WriteLine(numb[x]);
		}
	}
}
