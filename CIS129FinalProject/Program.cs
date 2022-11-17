// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

 class Characters {
    private int mp1;
    private String characterName;
     private int thehp;
    //private int damage;
    //private String Attack;
}

public Characters(int mp1, String characterName, int thehp){ 
    this.Mp1 = mp1;
    this.characterName = characterName;
    this.thehp = thehp;
    //this.damage= damage;
    //this.Attack = Attack;
}
// the goal here so far is to set up a character class and essentially
// give wizert and his enemies the neccessary shard properties
// like hp, name, attack or mp.
// it would be nice if i could make a sub class for the characters but i dont
//remember how to do that.
Characters Wizert = new Characters(200, "Wizert", 100);
Characters Orc = new Characters(3, "Orc", 5);
Characters Goblin = new Characters(2, "Goblin", 3);
Characters Banshee = new Characters(5, "Banshee", 5);
// i think this is supposed to be a powerup
public class powerUps { 
    private int healthPotion = 10;
    private int magickaPotion = 20;
}
// this is supposed to be my main class

public class main(){ 
    // i think that this is supposed to be a dungeon?
    // this is an array 5 by five but i dont know how to stick a wizert obj
    // in an array. maybe a hint??!?
    int[,] Dungeon = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 }, };
}
// this method is intended to handle wizert movements. at least in theory.
public void InputMove() { 
    Console.WriteLine("you find yourself in a new room in this dungeoun");
    Console.WriteLine("Press 1 to move wizert north");
    Console.WriteLine("Press 2 to move wizert south");
    Console.WriteLine("Press 3 to move Wizert east");
    Console.WriteLine("Press 4 to move Wizert west");
    int moveWizert = Console.ReadLine();
    if (moveWizert == 1) {}
    if (moveWizert == 2) {}
    if (moveWizert == 3) {}
    if (moveWizert == 4) {}
}
// this is intended to handle wizerts attack choices
public void attackWizert() { 
Console.WriteLine("Wizert has Encountered an Enemy");
Console.WriteLine("Press 1 to Attack");
Console.WriteLine("Press 2 to Run away");
Console.WriteLine("Press 3 to heal");
    int attackWizert1 = Console.ReadLine();
}
