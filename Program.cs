using System;
using System.Collections.Generic;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up required variables
            var cards = new List<string>();
            var var3 = 0;

            var ranks = new List<string>();
            ranks.Add("Ace");
            ranks.Add("2");
            ranks.Add("3");
            ranks.Add("4");
            ranks.Add("5");
            ranks.Add("6");
            ranks.Add("7");
            ranks.Add("8");
            ranks.Add("9");
            ranks.Add("10");
            ranks.Add("Jack");
            ranks.Add("Queen");
            ranks.Add("King");

            var suits = new List<string>();
            suits.Add("Diamonds");
            suits.Add("Spades");
            suits.Add("Hearts");
            suits.Add("Clubs");

            // Combine ranks and suits lists into one list of cards
            for (int var1 = 0; var1 < ranks.Count; ++var1)
            {

                for (int var2 = 0; var2 < suits.Count; ++var2)
                {
                    cards.Add(ranks[var1] + " of " + suits[var2]);
                    var3++;
                }
            }

            // Establish variables used for shuffling
            Random rnd = new Random();
            var tempVar = new List<string>();
            tempVar.Add("NaN");
            int firstIndex;
            int secondIndex;

            // Shuffle cards using the Fisher-Yates Algorthm
            for (var n = cards.Count - 1; n >= 0; --n)
            {
                firstIndex = n;
                secondIndex = rnd.Next(0, firstIndex);

                tempVar[0] = cards[firstIndex];
                cards[firstIndex] = cards[secondIndex];
                cards[secondIndex] = tempVar[0];
            }
            // Output the first two cards in the 'cards' List
            Console.WriteLine($"First card after shuffling the deck is: {cards[0]}");
            Console.WriteLine($"Second card after shuffling the deck is: {cards[1]}");
        }

    }
}
