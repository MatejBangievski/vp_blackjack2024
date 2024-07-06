using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player //TODO
    {
        public string username {  get; set; }
        public int balance { get; set; }
        public Image profilepic { get; set; }
        public PaymentCard paymentCard { get; set; }

        public Player(string username, int balance, Image image, PaymentCard paymentCard)
        {
            this.username = username;
            this.balance = balance;
            this.profilepic = image;
            this.paymentCard = paymentCard;
        }

        public void IncreaseBalacne (int win)
        {
            balance += win;
        }

        public void DecreaseBalacne(int loss)
        {
            balance -= loss;
        }
    }
}
