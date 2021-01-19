using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Models
{
    class Card
    {
        SUITE suite;
        int value;

        public enum SUITE
        {
            Heart,
            Spade,
            Diamond,
            Club
        }

        public Card(int value, SUITE suite)
        {
            this.value = value;
            this.suite = suite;
        }

        override
        public String ToString()
        {
            return value + " of " + suite;
        }
    }
}
