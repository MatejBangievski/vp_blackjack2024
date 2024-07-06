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
    public partial class FormCreation : Form
    {
        public int playerpicture; //index na slika
        public Image[] profilepictures; //niza od sliki
        public PaymentCard paymentcard;
        public FormCreation()
        {
            InitializeComponent();
        }

        private void FormCreation_Load(object sender, EventArgs e)
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
            if (tb_amount.Text != "0$")
            {
                FormPlay formPlay = new FormPlay();
                //Позицијата да е иста како овој form
                formPlay.StartPosition = FormStartPosition.Manual;
                int centerX = this.Location.X + (this.Width / 2) - (formPlay.Width / 2);
                int centerY = this.Location.Y + (this.Height / 2) - (formPlay.Height / 2);
                formPlay.Location = new Point(centerX, centerY);
                formPlay.Location = this.Location;

                //Се креира објект од играч и се предава на формата
                string username = tb_name.Text;
                int balacne = paymentcard.Amount;
                Image image = profilepictures[playerpicture];

                Player player = new Player(username, balacne, image, paymentcard);
                formPlay.player = player;

                //VISIBLE - ja pravi nevidliva prvichnata forma. Efekt demek se zatvara
                this.Visible = false;
                formPlay.ShowDialog();
                this.Close();
            }

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

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();

            //Pozicijata da e ista ko na ovoj form
            payment.StartPosition = FormStartPosition.Manual;

            //Локација за да е одма десно до моменталната форма
            Point right = new Point(this.Location.X + this.Width, this.Location.Y);
            payment.Location = right;

            payment.ShowDialog();

            if (payment.DialogResult == DialogResult.OK) //Успешен deposit
            {
                paymentcard = payment.playercard;
                tb_amount.Text = paymentcard.Amount + "$";
            }
        }
    }
}
