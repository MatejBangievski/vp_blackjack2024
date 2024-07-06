using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class DeckTest : Form
    {
        Deck deck;
        public DeckTest()
        {
            InitializeComponent();
            DoubleBuffered = true;
            deck = new Deck();
            addCardsToList();
        }

        private void DeckTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deck.ShuffleDeck();
            addCardsToList();
        }


        public void addCardsToList()
        {
            listBox1.Items.Clear();
            foreach (Card card in deck.cards)
            {
                listBox1.Items.Add(card);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card card = deck.DealCard();
            if (card != null)
            {
                listBox2.Items.Add(card);
                addCardsToList();
            }
        }
    }
}
