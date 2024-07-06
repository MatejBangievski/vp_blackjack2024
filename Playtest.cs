using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Playtest : Form
    {
        public Player player;
        public List<Card> dealerCards;
        public int dealerTotal;
        public List<Card> playerCards;
        public int playerTotal;
        public int wager;
        public bool roundWon; // Dali pobedil ili ne
        public List<Chip> chips; // Ke gi dodavam chipovite za draw metodot
        public Playtest()
        {
            InitializeComponent();
            DoubleBuffered = true;
            dealerCards = new List<Card>();
            playerCards = new List<Card>();
            dealerTotal = 0;
            playerTotal = 0;
            wager = 0;
        }

        private void Playtest_Load(object sender, EventArgs e)
        {
            pb_profilepic.Image = player.profilepic;
            lbl_name.Text = player.username;
            lbl_balance.Text = $"${player.balance}";
            //Stavi max sho moze da se kocka e negoviot cel balans
            nud_wager.Maximum = player.balance;

            //Imam labeli za da zemam lokacii - gi stavam na invisible
            lbl_position1.Visible = false;
            lbl_position2.Visible = false;
            lbl_position3.Visible = false;
            lbl_position4.Visible = false;

            //Nacrtaj chipovi
            //ZA lokacija zimam od labeli
            Chip chip1 = new Chip(10, Color.Blue, lbl_position1.Location);

            Chip chip2 = new Chip(25, Color.Red, lbl_position2.Location);

            Chip chip3 = new Chip(100, Color.Purple, lbl_position3.Location);

            Chip chip4 = new Chip(1000, Color.Black, lbl_position4.Location);

            chips = new List<Chip>() { chip1, chip2, chip3, chip4};
            Invalidate();
        }

        public void UpdatePlayerBalance(int wager)
        {
            int remaining_balance = player.balance - (int)nud_wager.Value;
            //TODO
        }

        private void Playtest_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (chips.Count > 0)
            {
                foreach (Chip chip in chips)
                {
                    chip.Draw(g);
                }
            }

        }

        private void Playtest_MouseClick(object sender, MouseEventArgs e)
        {
            // LEFT CLICK - ADD
            if (e.Button == MouseButtons.Left)
            {
                foreach (Chip chip in chips)
                {
                    if (chip.Hit(e.Location))
                    {
                        if (nud_wager.Value + chip.Price > nud_wager.Maximum)
                        {
                            // Stavi go na najmnogu so moze
                            nud_wager.Value = nud_wager.Maximum;
                        }
                        else
                        {
                            nud_wager.Value += chip.Price;
                        }
                    }
                }
            } 
            // RIGHT CLICK - REMOVE
            else if (e.Button == MouseButtons.Right)
            {
                foreach (Chip chip in chips)
                {
                    if (chip.Hit(e.Location))
                    {
                        if (nud_wager.Value - chip.Price < nud_wager.Minimum) {
                            // Stavi go na najmalku so moze
                            nud_wager.Value = nud_wager.Minimum;
                        } else
                        {
                            nud_wager.Value -= chip.Price;
                        }
                    }
                }
            }

        }
    }
}
