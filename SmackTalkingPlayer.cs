using System;


namespace ShootingDice
{

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }
        public override int Roll()
        {
            Console.WriteLine($"{Name} shouts '{Taunt}' at the top of their lungs as they roll");
            return base.Roll();
            
        }
    }

}