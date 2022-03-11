using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            SoreLoserUpperHalfPlayer cheatingButNotSatisfied = new SoreLoserUpperHalfPlayer();
            cheatingButNotSatisfied.Name = "Nobody's favorite opponent";

            UpperHalfPlayer upperDecker = new UpperHalfPlayer();
            upperDecker.Name = "always on top";

            SoreLoserPlayer neverGonnaLose = new SoreLoserPlayer();
            neverGonnaLose.Name="Your little sibling";

           

            CreativeSmackTalkingPlayer IntellectualInsulter = new CreativeSmackTalkingPlayer();
            IntellectualInsulter.Name = "Buzz Killington";
            IntellectualInsulter.tauntBank.Add("Away, you starvelling, you elf-skin, you dried neat’s-tongue, bull’s-pizzle, you stock-fish!");
            IntellectualInsulter.tauntBank.Add("I am sick when I do look on thee");
            IntellectualInsulter.tauntBank.Add("I’ll beat thee, but I would infect my hands.");
            IntellectualInsulter.tauntBank.Add("More of your conversation would infect my brain.");
            HumanPlayer MrRoboto = new HumanPlayer();
            MrRoboto.Name = "Wall-E";

            OneHigherPlayer cheaterCheaterPumpkinEater = new OneHigherPlayer();
            cheaterCheaterPumpkinEater.Name= "Sore Winner";
            try
            {
            neverGonnaLose.Play(cheaterCheaterPumpkinEater);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            SmackTalkingPlayer smackPlayer = new SmackTalkingPlayer();
            smackPlayer.Name="Jury Byrd";
            smackPlayer.Taunt="Your mom goes to college!";
            
            IntellectualInsulter.Play(smackPlayer);
            Console.WriteLine("-------------------");
            cheaterCheaterPumpkinEater.Play(smackPlayer);

            Console.WriteLine("-------------------");
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";
            smackPlayer.Play(player2);
            Console.WriteLine("-------------------");
            player2.Play(smackPlayer);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            cheaterCheaterPumpkinEater.Play(large);

            Console.WriteLine("-------------------");
            cheatingButNotSatisfied.Play(player1);
            Console.WriteLine("-------------------");

            MrRoboto.Play(player1);
           
            Console.WriteLine("-------------------");


            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackPlayer
            };

            PlayMany(players);
            upperDecker.Play(player1);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}