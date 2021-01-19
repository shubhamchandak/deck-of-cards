using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static HouseOfCards.Models.Card;

namespace HouseOfCards.Models
{
    class Deck
    {
        List<Card> deck;
        private readonly Random _random = new Random();

        public Deck()
        {
            this.deck = new List<Card>();
            for (int i = 1; i <= 13; i++)
            {
                foreach(SUITE suite in Enum.GetValues(typeof(SUITE)))
                {
                    deck.Add(new Card(i, suite));
                }
            }
        }

        public Card DealCard()
        {
            if (deck.Count > 0)
            {
                Card removedCard = deck[0];
                deck.RemoveAt(0);
                return removedCard;
            }
            return null;
        }

        public bool Shuffle()
        {
            if (deck.Count < 1) return false;
            for (int i = 0; i < deck.Count; i++)
            {
                int firstCard = _random.Next(deck.Count);
                int secondCard = _random.Next(deck.Count);
                Card temp = deck[firstCard];
                deck[firstCard] = deck[secondCard];
                deck[secondCard] = temp;
            }
            return true;
        }

        public void Reset()
        {
            this.deck = new List<Card>();
            for (int value = 1; value <= 13; value++)
            {
                foreach (SUITE suite in Enum.GetValues(typeof(SUITE)))
                {
                    deck.Add(new Card(value, suite));
                }
            }
        }
    }
}
