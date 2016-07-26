using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReubenEllis_Week4_DiceRollModified
{
    class SuperDice
    {
        //randomRoll will be used to create a random value for each dice roll
        private Random
            randomRoll = new Random();

        public int diceRoll1 { get; set; }
        public int diceRoll2 { get; set; }

        public int RollValueDice1()
        {
            diceRoll1 = randomRoll.Next(1, 7);

            return diceRoll1;
        }
        public int RollValueDice2()
        {
            diceRoll2 = randomRoll.Next(1, 7);

            return diceRoll2;
        }
    }
}
