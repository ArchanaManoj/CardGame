//Project submitted by Archana Manoj, archana.manoj@gmail.com, dated 08/25/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public enum CardSuit
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public CardSuit CardSuit { get; set; }
        public CardValue CardValue { get; set; }

        public Card(CardSuit cardSuit, CardValue cardValue)
        {
            CardSuit = cardSuit;
            CardValue = cardValue;
        }
    }

    public class Deck
    {
        public List<Card> GetPack()
        {
            List<Card> mydeck = new List<Card>();
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue val1 in Enum.GetValues(typeof(CardValue)))
                {
                    mydeck.Add(new Card(suit, val1));
                }
            }

            return mydeck;
        }

        public List<Card> ShufflePack(List<Card> pack)
        {
            Random num = new Random();
            for (int i = pack.Count - 1; i > 0; i--)
            {
                int n1 = num.Next(i);
                Card temp = pack[i];
                pack[i] = pack[n1];
                pack[n1] = temp;
            }
            return pack;
        }

        public List<Card> SortPack(List<Card> pack)
        {
            return pack.OrderBy(x => x.CardValue).OrderBy(r => r.CardSuit).ToList();
        }

        public List<Card> DisplayPack(List<Card> pack)
        {
            foreach (var item in pack)
            {
                Console.WriteLine(item.CardValue + " of " + item.CardSuit);
            }

            return pack;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deck play = new Deck();
            List<Card> newdeck = play.GetPack();

            Console.WriteLine("Get a new deck");

            play.DisplayPack(newdeck);

            newdeck = play.ShufflePack(newdeck);

            Console.WriteLine("Shuffle the ordered deck");

            play.DisplayPack(newdeck);

            newdeck = play.SortPack(newdeck);

            Console.WriteLine("Sort the shuffled deck");

            play.DisplayPack(newdeck);

            Console.ReadLine();
        }
    }
}
