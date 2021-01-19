using HouseOfCards.Models;
using System;

namespace HouseOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Please Enter 'D', 'S' or 'R' to Deal a card, Shuffle a deck or Reset the deck respectively.");
            while (true)
            {
                var input = Convert.ToString(Console.ReadLine());
                if (input.ToLower() == "d")
                {
                    var card = deck.DealCard();
                    Console.WriteLine(card == null ? "No more cards available! Please reset the deck." : card.ToString());
                }
                else if (input.ToLower() == "s")
                {
                    var shuffle = deck.Shuffle();
                    Console.WriteLine(shuffle ? "Deck shuffled successfully!" : "No cards available! Please reset the deck.");
                }
                else if (input.ToLower() == "r")
                {
                    deck.Reset();
                    Console.WriteLine("Deck reset succesfully!");
                }
                else
                {
                    Console.WriteLine("Invalid Command!");
                    Console.WriteLine("Please Enter 'D', 'S' or 'R' to Deal a card, Shuffle a deck or Reset the deck respectively.");
                }
            }
        }
    }
}
