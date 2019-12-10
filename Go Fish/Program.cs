using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish
{
    class Card
    {
        public int value { get; set; }
        public int suit { get; set; }

        public Card(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
    }

    class Deck
    {
        public List<Card> deck;

        public Deck(Random rand)
        {
            deck = new List<Card>();
            CreateDeck();
            ShuffleDeck(rand);
        }

        public void CreateDeck()
        {
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int valueIndex = 1; valueIndex < 14; valueIndex++)
                {
                    deck.Add(new Card(suitIndex, valueIndex));
                }
            }
        }

        public void ShuffleDeck(Random rand)
        {
            int n = deck.Count;
            for (int i = 0; i < (n - 1); i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int r = i + rand.Next(n - i);
                Card temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }
        }

        public List<Card> DrawHand(Random rand, int num_cards)
        {
            List<Card> hand = new List<Card>();
            int i = 0;
            while(i < num_cards)
            {
                int randomIndex = rand.Next(deck.Count);
                //Console.WriteLine("random index "+randomIndex);
                //Console.WriteLine("Deck value "+deck[randomIndex].value);
                if (deck[randomIndex].value != 0)
                {
                    hand.Add(new Card(deck[randomIndex].suit, deck[randomIndex].value));
                    deck.RemoveAt(randomIndex);
                    i++;
                }
                else
                    continue;
                
            }

            return hand;
        }
    }

    class Player
    {
        public int score { get; set; }
        public Player()
        {
            this.score = 0;
        }
    }

    class GoFishGame
    {
        Random rand;
        Player player1;
        Player player2;
        Deck sampleDeck;

        public GoFishGame()
        {
            rand = new Random();
            player1 = new Player();
            player2 = new Player();
            sampleDeck = new Deck(rand);
        }

        public void PlayGame()
        {
            List<Card> player1Hand = sampleDeck.DrawHand(rand,5);
            List<Card> player2Hand = sampleDeck.DrawHand(rand,5);

            foreach (var item in player1Hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }

            Console.WriteLine();

            foreach (var item in player2Hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }

            Console.WriteLine();

            //foreach (var item in player1Hand)
            //{
            //    if(item.value)
            //}
            for (int i = 0; i < player1Hand.Count; i++)
            {
                for(int j = i+1; j < player1Hand.Count; j++)
                {
                    //Console.WriteLine(player1Hand[i].value + " " + player1Hand[j].value);
                    if (j < player1Hand.Count && player1Hand[i].value == player1Hand[j].value)
                    {
                        player1.score += 1;
                        player1Hand.RemoveAt(i);
                        player1Hand.RemoveAt(j);
                        continue;
                    }
                    else if (j < player2Hand.Count && player2Hand[i].value == player2Hand[j].value)
                    {
                        player2.score += 1;
                        player2Hand.RemoveAt(i);
                        player2Hand.RemoveAt(j);
                        continue;
                    }
                    else
                        continue;
                }
            }

            Console.WriteLine(player1.score + " " + player2.score);

            Console.WriteLine();

            foreach (var item in player1Hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }

            Console.WriteLine();

            foreach (var item in player2Hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GoFishGame game = new GoFishGame();
            game.PlayGame();
        }
    }
}
