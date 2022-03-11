using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer:Player
    {
        public List<string> tauntBank = new List<string>();
        public override int Roll()
        {
            int listSize = tauntBank.Count;
            int selectTaunt=new Random().Next(listSize);
            string taunt = tauntBank[selectTaunt];
            Console.WriteLine($"{Name} shouts '{taunt}' at the top of their lungs as they roll");
            return base.Roll();
        }
    }
}