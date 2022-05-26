using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
         public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(3,DiceSize) + 1;
        }
    }
}