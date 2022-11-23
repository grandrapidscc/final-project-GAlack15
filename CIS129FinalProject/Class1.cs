using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Wizert wizert = new Wizert(3, 0, 10, 10);
            int[,] array = new int[5, 5];
            int yourLocation = array[wizert.xPos, wizert.yPos];
            // enemies go here
            Enemies Goblin = new Enemies(1, 0, 3);
            int goblinLocation = array[Goblin.xPos, Goblin.yPos];
            Enemies Orc = new Enemies(3, 2, 5);
            int orcLocation = array[Orc.xPos, Orc.yPos];
            Enemies Banshee = new Enemies(4, 4, 8);
            int bansheeLocation = array[Banshee.xPos, Banshee.yPos];
            powerUps Health = new powerUps(4, 1);
            int powerupLocation = array[Health.xPos, Health.yPos];

            // ask user a question.
            Console.WriteLine("You the all powerful Wizert sought out new magical knowledge");
            Console.WriteLine("after successfully obtaining what you sought and completing the quest");
            Console.WriteLine("you find the only way to leave the Sorcerer's Tower, is to go through an old dungeon");
            Console.WriteLine(" you have entered the dungeon and you cannot go back a wall closes behined you, do you want to go 1 for north, 2 for west, and 3 for east?");
            Console.WriteLine(wizert.xPos);
            Console.WriteLine(wizert.yPos);
            string UserNum = Console.ReadLine();

            // first if statement starts
            if (UserNum == "1")
                {
                    Console.WriteLine(" Wizert Moves up one space in the array");
                    wizert.yPos = wizert.yPos + 1;
                    Console.WriteLine(wizert.yPos);
                    Console.WriteLine(wizert.xPos);
                }
                else if (UserNum == "2")
                {
                    Console.WriteLine(" Wizert Moves west one space in the array");
                    wizert.xPos = wizert.xPos - 1;
                    Console.WriteLine(wizert.xPos);
                    Console.WriteLine(wizert.yPos);
                   }
                else if (UserNum == "3")
                {
                    Console.WriteLine("Wizert moves one space to the east in the array");
                    wizert.xPos = wizert.xPos + 1;
                    Console.WriteLine(wizert.xPos);
                    Console.WriteLine(wizert.yPos);
                }
    //first if statement comes to an end


                // first attack statement
                if (wizert.xPos == 2 && wizert.yPos == 0) {
                Console.WriteLine(" while Adventuring Wizert encounters a goblin, press 1 for attack, 2 for heal, 3 to flee");

                }
        }
    }
}
