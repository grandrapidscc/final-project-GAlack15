// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;



public class room {
    public Enemies Enemies;
    public string RoomDescription;
    public powerUps potions;
    
}


public class Wizert
{
    public int xPos;
    public int yPos;
    public int health;
    public int magic;

    public Wizert(int xPos, int yPos, int health, int magic)
    {
        this.xPos = xPos;
        this.yPos = yPos;
        this.health = health;
        this.magic = magic;
    }

}

public class Enemies {
       
        public int health;
    public Enemies() {
        
        this.health = health;
    }
       
    }

        public class powerUps {
            private int healthPotion = 2;
            private int magickaPotion = 2;
            public int xPos;
             public int yPos;
    public powerUps(int xPos, int yPos)
            {
                this.xPos=xPos;
                this.yPos=yPos;      
            }
        }

//public Characters{}
// the goal here so far is to set up a character class and essentially
// give wizert and his enemies the neccessary shard properties
// like hp, name, attack or mp.
// it would be nice if i could make a sub class for the characters but i dont
//remember how to do that.
//Characters Wizert = new Characters(200, "Wizert", 100);
//Characters Orc = new Characters(3, "Orc", 5);
//Characters Goblin = new Characters(2, "Goblin", 3);
//Characters Banshee = new Characters(5, "Banshee", 5);
// i think this is supposed to be a powerup

// this is supposed to be my main class

// this method is intended to handle wizert movements. at least in theory.
//void InputMove()
//{
//    Console.WriteLine("you find yourself in a new room in this dungeoun");
//    Console.WriteLine("Press 1 to move wizert north");
//    Console.WriteLine("Press 2 to move wizert south");
//    Console.WriteLine("Press 3 to move Wizert east");
//    Console.WriteLine("Press 4 to move Wizert west");
//    string moveWizert = Console.ReadLine();
//    if (moveWizert == "1") { }
//    if (moveWizert == "2") { }
//    if (moveWizert == "3") { }
//    if (moveWizert == "4") { }
//}
// this is intended to handle wizerts attack choices
//void attackWizert()
//{
//    Console.WriteLine("Wizert has Encountered an Enemy");
//    Console.WriteLine("Press 1 to Attack");
//    Console.WriteLine("Press 2 to Run away");
//    Console.WriteLine("Press 3 to heal");
//    string attackWizert1 = Console.ReadLine();
//}