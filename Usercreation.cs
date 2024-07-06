using Blackjack.Properties;
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
    public partial class Usercreation : Form
    {
        public int playerpicture; //index na slika
        public Image[] profilepictures; //niza od sliki
        public Usercreation()
        {
            InitializeComponent();
        }

        private void Usercreation_Load(object sender, EventArgs e)
        {
            // deka e niza pocnuvame od 0, inace se misli na PLAYER 1
            playerpicture = 0;
            profilepictures = new Image[]
            {
                Properties.Resources.PLAYER1, //0
                Properties.Resources.PLAYER2, //1
                Properties.Resources.PLAYER3, //2
                Properties.Resources.PLAYER4, //3
                Properties.Resources.PLAYER5, //4 
                Properties.Resources.PLAYER6  //5
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerpicture == 5)
            {
                playerpicture = 0;
            } else
            {
                playerpicture++;
            }
            pictureBox1.Image = profilepictures[playerpicture];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (playerpicture == 0)
            {
                playerpicture = 5;
            }
            else
            {
                playerpicture--;
            }
            pictureBox1.Image = profilepictures[playerpicture];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Playtest playtest = new Playtest();
            //Pozicijata da e ista ko na ovoj form
            playtest.StartPosition = FormStartPosition.Manual;
            playtest.Location = this.Location;

            //Ke nparavam objekt od Player i ke go predadam na formata
            string username = tb_name.Text;
            int balacne = (int) nud_balance.Value; //Vrakja decimal - cast vo int
            Image image = profilepictures[playerpicture];

            Player player = new Player(username, balacne, image);
            playtest.player = player;

            //VISIBLE - ja pravi nevidliva prvichnata forma. Efekt demek se zatvara
            this.Visible = false;
            playtest.ShowDialog();
            this.Close();
        }

        private void tb_name_Validating(object sender, CancelEventArgs e)
        {
            // Za validacija - da ima vneseno ime
            if (tb_name.Text.Length > 0)
            {
                errorProviderName.SetError(tb_name, null);
                e.Cancel = false;
            } else
            {
                errorProviderName.SetError(tb_name, "Please enter your name:");
                e.Cancel = true;
            }
        }
    }
}
