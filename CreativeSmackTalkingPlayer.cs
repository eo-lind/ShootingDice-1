using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        public CreativeSmackTalkingPlayer(string name)
        {   
            Name = name;
        }
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            List<string> taunts = new List<string>();
            taunts.Add("Suck it!");
            taunts.Add("Go Home!");
            taunts.Add("Gimme that money!");
            var random = new Random();
            int taunt = random.Next(0, taunts.Count);
            Console.WriteLine(taunts[taunt]);
            return new Random().Next(DiceSize) + 1;
        }
    }
}