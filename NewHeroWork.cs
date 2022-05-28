//DGM 1610 Calvin Ambrose

using System;
					
public class Program
{
    public Hero heroOne;
    public Hero heroTwo;
	public Hero heroThree;
	public Hero heroFour;
	
    public void Main()
    {
       heroOne = new Hero();
       heroTwo = new Hero();
		   heroThree = new Hero();
		   heroFour = new Hero();
		
        heroOne.health = 2;
        heroOne.powerLevel = 5;
		    heroOne.speed = 3;
		    heroOne.vision = 2;
		
        heroTwo.health = 3;
        heroTwo.powerLevel = 1;
		    heroTwo.speed = 4;
		    heroTwo.vision = 4;
		
		    heroThree.health = 4;
		    heroThree.powerLevel = 4;
		    heroThree.speed = 1;
		    heroThree.vision = 2;
		
		    heroFour.health = 3;
		    heroFour.powerLevel = 3;
		    heroFour.speed = 2;
		    heroFour.vision = 3;
		
		    Console.WriteLine("Hero One");
        Console.WriteLine(heroOne.health);
        Console.WriteLine(heroOne.powerLevel);
		    Console.WriteLine(heroOne.speed);
		    Console.WriteLine(heroOne.vision + "\n");
		
        Console.WriteLine("Hero Two");
        Console.WriteLine(heroTwo.health);
        Console.WriteLine(heroTwo.powerLevel);
		    Console.WriteLine(heroTwo.speed);
		    Console.WriteLine(heroTwo.vision + "\n");
			
		    Console.WriteLine("Hero Three");
        Console.WriteLine(heroThree.health);
        Console.WriteLine(heroThree.powerLevel);
		    Console.WriteLine(heroThree.speed);
		    Console.WriteLine(heroThree.vision + "\n");
			
		    Console.WriteLine("Hero Four");
        Console.WriteLine(heroFour.health);
        Console.WriteLine(heroFour.powerLevel);
		    Console.WriteLine(heroFour.speed);
		    Console.WriteLine(heroFour.vision + "\n");
		
    }
}

public class Hero {
    public int health;
    public int powerLevel;
	  public int speed;
	  public int vision;
}
