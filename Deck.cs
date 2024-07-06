using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Blackjack
{
    public class Deck
    {
        public List<Card> cards;
        Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            //Pravenje na shpil karti
            string[] suits = { "heart", "spade", "club", "diamond" }; //Niza od site znaci
            foreach (string suit in suits)
            {
                //Mozni vrednosti 1 - 10, J, Q, K,
                for (int i = 1; i <= 10; i++) // 
                {
                    cards.Add(new Card(suit, i.ToString()));
                }
                //Razmislete za bolje nachin :)
                cards.Add(new Card(suit, "J"));
                cards.Add(new Card(suit, "Q"));
                cards.Add(new Card(suit, "K"));
            }
        }

        public void ShuffleDeck()
        {
            // Ke napravam temporary lista i tamu ke gi dodavam, i na kraj ke ja predadam taa lista
            List<Card> shuffledcards = new List<Card>();

            while (cards.Count > 0)
            {
                int position = random.Next(0, cards.Count);
                Card card = cards[position];
                shuffledcards.Add(card);
                cards.Remove(card);
            }

            cards = shuffledcards;
        }

        public Card DealCard () // Daj karta, otstrani ja od listata
        {
            if (cards.Count > 0)
            {
                int position = random.Next(0, cards.Count);
                Card selected_card = cards[position];
                cards.Remove(selected_card);

                return selected_card;
            } else
            {
                return null;
            }

        }
    }
}
