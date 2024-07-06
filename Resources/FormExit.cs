using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack.Resources
{
    public partial class FormExit : Form
    {
        public int profitOrLoss {  get; set; }
        public int totalGames { get; set; }
        public int totalWins { get; set; }
        public SoundPlayer winner { get; set; }
        public SoundPlayer loser { get; set; }
        public FormExit()
        {
            InitializeComponent();
            winner = new SoundPlayer(Properties.Resources.winner_sound);
            loser = new SoundPlayer(Properties.Resources.loser_sound_v2);
        }

        private void FormExit_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (profitOrLoss > 0) //Победил
            {
                lbl_wonlost.Text = "You won " + profitOrLoss + "$ !!!";
                winner.Play();
            } else //Изгубил
            {
                lbl_wonlost.Text = "You lost " + profitOrLoss + "$";
                loser.Play();
            }

            lbl_totalgames.Text = "Total games: " + totalGames;
            lbl_totalwins.Text = "Total wins: " + totalWins;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close(); //Изгаси ја формата
        }
    }
}
