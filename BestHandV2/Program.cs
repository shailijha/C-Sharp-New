using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHandV2
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

    class Player
    {
        public int score { get; set; }
        public Player()
        {
            this.score = 0;
        }

        public void CalculateScore(List<Card> playerHand)
        {
            foreach (var item in playerHand)
            {
                if (item.value == 1)
                    this.score += 11;
                else if (item.value == 11 || item.value == 12 || item.value == 13)
                    this.score += 10;
                else
                    this.score += item.value;
            }
        }
    }

    class Deck
    {
        public List<Card> deck;
        public List<Card> discardDeck;

        public Deck(Random rand)
        {
            deck = new List<Card>();
            discardDeck = new List<Card>();
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
            int randomIndex = rand.Next(deck.Count);
            for (int i = 0; i < num_cards; i++)
            {
                hand.Add(new Card(deck[randomIndex].suit, deck[randomIndex].value));
                deck.RemoveAt(randomIndex);
            }
            Console.WriteLine("Number of cards left in the deck are " + deck.Count);
            return hand;
        }

        public bool CheckValidExchange(int number_cards_exchanged)
        {
            int[] fibb_series = new int[] { 1, 2, 3, 5, 8 };

            if (!fibb_series.Contains(number_cards_exchanged))
            {
                Console.WriteLine("Exchange of fibb number of cards allowed only");
                return false;
            }
            else
                return true;
        }

        public List<Card> ExchangeCard(List<Card> hand, ArrayList indexes , Random rand)
        { 
            foreach (int index in indexes)
            {
                int randomIndex = rand.Next(deck.Count);
                hand.RemoveAt(index);
                hand.Insert(index, new Card(deck[randomIndex].suit, deck[randomIndex].value));
                deck.RemoveAt(randomIndex);
                deck.Add(new Card(hand[index].suit, hand[index].value));
            }

            foreach (var item in hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }

            Console.WriteLine("Number of cards left in the deck are " + deck.Count);
            return hand;
        }

        public void DiscardCard(Card card, List<Card> hand)
        {
            discardDeck.Add(new Card(card.suit, card.value));
            hand.Remove(card);
        }
    }

    class Game
    {
        Random rand;
        Player player1;
        Deck deck;

        public Game()
        {
            rand = new Random();
            player1 = new Player();
            deck = new Deck(rand);
        }

        public void PlayGame()
        {
            List<Card> player1Hand = deck.DrawHand(rand, 8);

            Console.WriteLine("Player 1's hand is ");
            foreach (var item in player1Hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }

            Console.WriteLine();

            //logic for exchanging cards b/w hand and deck
            string answer;

            Console.WriteLine("Do you want to exchange any cards?");
            answer = Console.ReadLine();

            if(answer.ToLower() == "yes")
            {
                Console.WriteLine("How many cards do you want to exchange?");
                int number_cards_exchange = Convert.ToInt32(Console.ReadLine());

                if(deck.CheckValidExchange(number_cards_exchange))
                {
                    Console.WriteLine("Valid Exchange. Enter comma separated index(s) of cards you want to exchange");
                    string index_string = Console.ReadLine();
                    string[] individual_index_string = index_string.Split(',');
                    ArrayList indexes = new ArrayList();

                    foreach (var item in individual_index_string)
                    {
                        indexes.Add(Convert.ToInt32(item));
                    }

                    player1Hand = deck.ExchangeCard(player1Hand, indexes, rand);
                }
                //******WRITE CODE LATER TO ACCOMODATE FALSE RESULT RETURNED FROM THE CHECK VALID EXCHANGE FUNCTION******
            }

            foreach (var item in player1Hand)
            {
                Console.WriteLine(item.suit + " " + item.value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game sampleGame = new Game();
            sampleGame.PlayGame();
        }
    }
}
