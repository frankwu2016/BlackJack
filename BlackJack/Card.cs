﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        public Card(string name, Suit suit)
        {
            this.Name = name;
            this.Suite = suit;
            this.NumberValue = SetNumberValue(name);
        }
        
        public string Name { get; set; }
        public Suit Suite { get; set; }
        public int NumberValue { get; set; }

        /// <summary>
        /// Display function. Shows card in format "2 - Hearts" or "X - Clubs"
        /// </summary>
        public void DisplayCard()
        {
            Console.WriteLine("{0} - {1}", Name, Suite.ToString());
        }

        /// <summary>
        /// Determines whether or not this card is an Ace
        /// </summary>
        /// <returns></returns>
        public bool IsAce()
        {
            return Name == "A";
        }

        /// <summary>
        /// Determines whether or not this cards is worth 10
        /// </summary>
        /// <returns></returns>
        public bool IsTenCard()
        {
            return Name == "X" || Name == "J" || Name == "Q" || Name == "K";
        }


        /// <summary>
        /// Sets a number value to each card. 2-10 are set to the value on their card. J, Q, K are equal to 10 and A = 1 or 11. We may need to put rules to this, but not likely at the card level.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int SetNumberValue(string name)
        {
            int value = 0;
            switch(name)
            {
                case "X":
                case "J":
                case "Q":
                case "K":
                    value = 10;
                    break;
                case "A":
                    value = 11;
                    break;
                default:
                    value = Int32.Parse(name);
                    break;
            }
            return value;
        }
    }
}
