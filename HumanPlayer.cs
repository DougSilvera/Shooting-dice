using System;

namespace ShootingDice
{
    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write("Human what is your roll? ");
            int humanInput = int.Parse(Console.ReadLine());
            return humanInput;
        }
    }
}