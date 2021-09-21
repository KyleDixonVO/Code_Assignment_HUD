using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Assignment_HUD_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            float experience;
            experience = 0.0f;
            float badGuyXP;
            badGuyXP = 10.0f;
            float koboldXP = badGuyXP / 2.0f;
            float goblinXP = badGuyXP * 2.0f;
            float orcXP = badGuyXP * 3.5f;
            float lichXP = badGuyXP * 10.0f;
            float playerHealth;
            playerHealth = 100.0f;
            int lives;
            lives = 1;
            int spellSlots;
            spellSlots = 5;
            int enemiesKilled;

            Console.WriteLine("Shotty Game Studios:");
            Console.WriteLine("Super Cool Fantasy Game, The Movie, The Game.");
            Console.ReadKey(true);
            Console.WriteLine("//See code for multipliers, all enemy types use a modified base value.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadKey(true);
            
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Hitpoints: " + playerHealth);
            Console.WriteLine("Spell slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("You enter the dungeon, the air is foul and the floor uneven.");
            Console.ReadKey(true);
            Console.WriteLine("--I Search For Traps");
            Console.ReadKey(true);
            Console.WriteLine("You find a tripwire attached to a suspended blade.");
            Console.WriteLine("You successfully disarm the trap, but take 2 damage from scuffing your knee while working.");
            Console.WriteLine("You gain 15 XP.");
            Console.ReadKey(true);

            playerHealth = playerHealth - 2.0f;
            experience = experience + 15.0f;
            Console.WriteLine("");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Hitpoints: " + playerHealth);
            Console.WriteLine("Spell slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("");
            Console.ReadKey(true);
            
            Console.WriteLine("You proceed further into the dank halls, the crunching of bones under your feet.");
            Console.WriteLine("You enter into a large room, decorated with skulls on pikes with a large altar in the center of the room.");
            Console.WriteLine("Surrounding the altar you see 7 kobolds, 3 goblins, and 2 orcs.");
            Console.ReadKey(true);
            Console.WriteLine("--I Cast Fireball Centered On The Altar");
            Console.ReadKey(true);
            Console.WriteLine("You incinerate 5 of the kobolds and 1 goblin.");
            Console.WriteLine("You gain 45 XP.");
            Console.ReadKey(true);

            enemiesKilled = 5;
            experience = experience + (koboldXP * enemiesKilled) + goblinXP;
            spellSlots = spellSlots - 1;
            Console.WriteLine("");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Hitpoints: " + playerHealth);
            Console.WriteLine("Spell slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("The goblin and orcs counterattack, you are peppered with arrows and slashed by rusty blades.");
            Console.WriteLine("You take 65 points of damage.");
            Console.ReadKey(true);

            playerHealth = playerHealth - 65.0f;
            Console.WriteLine("");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Hitpoints: " + playerHealth);
            Console.WriteLine("Spell slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("--I Cast Magic Missle At The Orcs And Goblin");
            Console.ReadKey(true);
            Console.WriteLine("The goblin and one orc are disintegrated in a spray of glittering dust.");
            Console.WriteLine("You gain 90 XP.");
            Console.ReadKey(true);

            enemiesKilled = 2;
            experience = experience + goblinXP + (orcXP * enemiesKilled);
            spellSlots = spellSlots - 1;
            Console.WriteLine("");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Hitpoints: " + playerHealth);
            Console.WriteLine("Spell slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("The remaining orc throws themself upon the altar which seeths with a black-green smog.");
            Console.WriteLine("A skull appears, suspended in the air, a demi-lich. The lich speaks a single arcane rune and you feel your soul tugged from your body.");
            Console.WriteLine("You take 100 damage.");
            Console.WriteLine("");
            Console.ReadKey(true);

            playerHealth = playerHealth - 100.0f;
            lives = lives - 1;
            Console.WriteLine("");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Hitpoints: " + playerHealth);
            Console.WriteLine("Spell slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("");
            Console.ReadKey(true);

            Console.WriteLine("You die on the cold floor of the dungeon, and your corpse is raised as a thrall.");
            Console.WriteLine("==GAME OVER!==");
            Console.ReadKey(true);










            Console.ReadKey(true);
        }
    }
}
