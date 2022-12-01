using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            room Room = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies(){health = 3}
            };
            room Room2 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies()
                {health = 3}
            };
            room Room3 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies()
                {health = 3}
            };
            room Room4 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies()
                {health = 3}
            };
            room Room5 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies()
                {health = 3}
            };
            room Room6 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies()
                { health = 3 }
            };
            room Room7 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies() { health = 3 }
            }; 
            room Room8 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies() { health = 3 }
            }; 
            room Room9 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies() { health = 3 }
            };
            room Room10 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies() { health = 3 }
            };
            room Room11 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room12 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies() { health = 3 }
            };
            room Room13 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
                Enemies = new Enemies() { health = 3 }
            };
            room Room14 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room15 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room16 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room17 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room18 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room19 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room20 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            }; 
            room Room21= new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room22 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room23 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room24 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room Room25 = new room()
            {
                RoomDescription = "the room is damp and dimly lit by torches, has tons of mold, something lit those torches theres someone or something down here.",
            };
            room[] Dungeon = {Room, Room2, Room3, Room4, Room5, Room6,
                Room7, Room8, Room9, Room10, Room11, Room12,
                Room13, Room14, Room15, Room16, Room17, Room18, Room19,
                Room20, Room21, Room22, Room23, Room24, Room25};
           


            
            //Wizert wizert = new Wizert(3, 0, 10, 10);
           
            //int[,] array = new int[5, 5];
            //int yourLocation = array[wizert.xPos, wizert.yPos];
            //// enemies go here
            //Enemies Goblin = new Enemies(1, 0, 3);
            //int goblinLocation = array[Goblin.xPos, Goblin.yPos];
            //Enemies Orc = new Enemies(3, 2, 5);
            //int orcLocation = array[Orc.xPos, Orc.yPos];
            //Enemies Banshee = new Enemies(4, 4, 8);
            //int bansheeLocation = array[Banshee.xPos, Banshee.yPos];
            //powerUps Health = new powerUps(4, 1);
            //int powerupLocation = array[Health.xPos, Health.yPos];
            

            //void WizertDeath ()
            //{                              
            //    if (wizert.health < 0) { 
            //    Console.WriteLine("you suffer a critical Injury");
            //        Console.WriteLine("You have Failed to Complete your quest and you've lost all your health");
            //        Console.WriteLine("Game Over,  the Game will now reset (press 9 to end game)");
            //        wizert.xPos = 3;
            //    wizert.yPos = 0;
            //    Console.WriteLine("Terrible Injury -- you have a total of 5 health ");
            //    wizert.health = 5;
            //    Console.WriteLine("Defeat Penalty -- Magic is set to 5");
            //    wizert.magic = 5;
            //    }
            //}
            //void AttackGoblin()
            //{
            //    string end = "";
            //    if (wizert.xPos != Goblin.xPos && wizert.yPos != Goblin.yPos)
            //    {
            //        Console.WriteLine(" you did not find any Goblins");
            //    }
            //    else if (wizert.xPos == Goblin.xPos && wizert.yPos == Goblin.yPos)
            //    {
            //        Console.WriteLine("you Encounter a goblin!");
            //        while (wizert.health > 0 && Goblin.health > 0)
            //        {
                        
            //            Console.WriteLine(" press a for attack, b for run away, and c for heal");
            //            string attack = Console.ReadLine();
            //            if (attack == "a")
            //            {
            //                Console.WriteLine("Goblin attacks! lose 3 health");
            //                wizert.health = wizert.health - 3;
            //                Console.WriteLine("wizert health is now " + wizert.health);
            //                Console.WriteLine(" you cast a spell on the goblin, shooting a fireball from your hands the goblin loses 3 health");
            //                Goblin.health = Goblin.health - 3;
            //                Console.WriteLine(" Goblin health is now " + Goblin.health);
                            
            //            }
            //            else if (attack == "b")
            //            {
            //                Console.WriteLine(" you flee to your original location as The goblin Laughs at you, he also stole a page out of your spellbook.");
            //                wizert.xPos = 3;
            //                wizert.yPos = 0;
            //                Console.WriteLine("wizerts x position is  "+ wizert.xPos + "  and wizerts y position is " + wizert.yPos);
            //                end = "Gone";
            //                break;

            //            }
            //            else if (attack == "c")
            //            {    
            //                if (wizert.magic > 0)
            //                {
            //                    Console.WriteLine("you choose to heal yourself, - 5 magic");
            //                    wizert.magic = wizert.magic - 5;
            //                    wizert.health = wizert.health + 3;
            //                    Console.WriteLine("your magic lvl is now " + wizert.magic);
            //                }
            //                else {Console.WriteLine("you've exhausted your magical abilities"); }
            //            }

            //        }
            //    }
            //}

            //void AttackOrc()
            //{
            //    string end = "";
            //    if (wizert.xPos != Orc.xPos && wizert.yPos != Orc.yPos)
            //    {
            //        Console.WriteLine(" you did not find any Orcs");
            //    }
            //    else if (wizert.xPos == Orc.xPos && wizert.yPos == Orc.yPos)
            //    {
                    
            //        Console.WriteLine("you encounter a large orc raiding a treasure chest, you notice he carries a large biting sword and a shield");
            //        Console.WriteLine(" the Orc Snarls , what shall you do?");
            //        while (wizert.health > 0 && Orc.health > 0)
            //        {

            //            Console.WriteLine(" press a for attack, b for run away, and c for heal");
            //            string attack = Console.ReadLine();
            //            if (attack == "a")
            //            {
            //                Console.WriteLine("the Orc attacks you! you lose 4 health");
            //                wizert.health = wizert.health - 4;
            //                Console.WriteLine("wizert health is now " + wizert.health);
            //                Console.WriteLine(" you cast a spell on the Orc, shooting a fireball from your hands the Orc is burned loses 3 health");
            //                Orc.health = Orc.health - 3;
            //                Console.WriteLine(" Orc health is now " + Orc.health);
            //                WizertDeath();
            //            }
            //            else if (attack == "b")
            //            {
            //                Console.WriteLine(" you flee to your original location as The Orc  angrily searches for you,  upon failing to find you he returns to looting forgotten treasure.");
            //                wizert.xPos = 3;
            //                wizert.yPos = 0;
            //                Console.WriteLine("wizerts x position is  "+ wizert.xPos + "  and wizerts y position is " + wizert.yPos);
            //                end = "Gone";
            //                break;

            //            }
            //            else if (attack == "c")
            //            {
            //                if (wizert.magic > 0)
            //                {
            //                    Console.WriteLine("you choose to heal yourself, - 5 magic");
            //                    wizert.magic = wizert.magic - 5;
            //                    wizert.health = wizert.health + 3;
            //                    Console.WriteLine("your magic lvl is now " + wizert.magic);
            //                }
            //                else { Console.WriteLine("you've exhausted your magical abilities"); }
            //            }

            //        }
            //    }
            //}
            //void AttackBanshee()
            //{
            //    string end = "";
            //    if (wizert.xPos != Banshee.xPos && wizert.yPos != Banshee.yPos)
            //    {
            //        Console.WriteLine(" you did not find any monsters or clawmarks");
            //    }
            //    else if (wizert.xPos == Banshee.xPos && wizert.yPos == Banshee.yPos)
            //    {
            //        Console.WriteLine("you Encounter a Banshee!, the strange winged creature was asleep but immediately awakens becuase it can smell your magic");
            //        Console.WriteLine("you remember that Banshees feast on magical artifacts");
            //        while (wizert.health > 0 && Banshee.health > 0)
            //        {

            //            Console.WriteLine(" press a for attack, b for run away, and c for heal");
            //            string attack = Console.ReadLine();
            //            if (attack == "a")
            //            {
            //                Console.WriteLine("The Banshee chooses to strike!, it's sharp wolflike claws injur you and you lose 5 health");
            //                wizert.health = wizert.health - 5;
            //                Console.WriteLine("wizert health is now " + wizert.health);
            //                Console.WriteLine(" you cast a fire spell on the Banshee, Banshees are strong against magic but weak against fire");
            //                Console.WriteLine("the banshee is harmed by your fire and it loses 3 health");
            //                Banshee.health =Banshee.health - 3;
            //                Console.WriteLine(" Banshee health is now " + Banshee.health);

            //            }
            //            else if (attack == "b")
            //            {
            //                Console.WriteLine(" you flee to your original location .");
            //                wizert.xPos = 3;
            //                wizert.yPos = 0;
            //                Console.WriteLine("wizerts x position is  "+ wizert.xPos + "  and wizerts y position is " + wizert.yPos);
            //                end = "Gone";
            //                break;

            //            }
            //            else if (attack == "c")
            //            {
            //                if (wizert.magic > 0)
            //                {
            //                    Console.WriteLine("you choose to heal yourself, - 5 magic");
            //                    wizert.magic = wizert.magic - 5;
            //                    wizert.health = wizert.health + 3;
            //                    Console.WriteLine("your magic lvl is now " + wizert.magic);
            //                }
            //                else { Console.WriteLine("you've exhausted your magical abilities"); }
            //            }

            //        }
            //    }
            //}


            // ask user a question.
            //Console.WriteLine("You the all powerful Wizert sought out new magical knowledge");
            //Console.WriteLine("after successfully obtaining what you sought and completing the quest");
            //Console.WriteLine("you find the only way to leave the Sorcerer's Tower, is to go through an old dungeon");
            //Console.WriteLine(" you have entered the dungeon and you cannot go back a wall closes behined you, do you want to go 1 for north, 2 for west, and 3 for east?");
            //Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
            //Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
            //string UserNum = Console.ReadLine();









            //// first if statement starts

            //do
            //{
              
            //    if (UserNum == "1")
            //    {
            //        Console.WriteLine(" Wizert Moves up one space in the array");
            //        wizert.yPos = wizert.yPos + 1;
            //        Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
            //        Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
            //    }
            //    else if (UserNum == "2")
            //    {
            //        Console.WriteLine(" Wizert Moves west one space in the array");
            //        wizert.xPos = wizert.xPos - 1;
            //        Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
            //        Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
            //    }
            //    else if (UserNum == "3")
            //    {
            //        Console.WriteLine("Wizert moves one space to the east in the array");
            //        wizert.xPos = wizert.xPos + 1;
            //        Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
            //        Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
            //    }

             
            //    else if (UserNum == "4")
            //    {
            //   Console.WriteLine("Wizert moves one space to the south in the array");
            //    wizert.yPos = wizert.yPos - 1;
            //    Console.WriteLine(" wizerts y coordinate is " + wizert.yPos);
            //    Console.WriteLine("wizerts x coordinate is " + wizert.xPos);
            //    }


            //    // this is an attack method
            //   // AttackBanshee();
            //   // WizertDeath();
            //   // AttackGoblin();
            //   // AttackOrc();
            //    Console.WriteLine("do you want to go 1 for north, 2 for west, and 3 for east? or 4 for west?");
            //    UserNum = Console.ReadLine();
            //} while (UserNum != "9");      
        }
    }
}
