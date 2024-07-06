using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public string suit {  get; set; }
        //public int number { get; set; }
        public Color color { get; set; }
       // public Point center { get; set; }
        public string value { get; set; } // string radi J, Q, K

        public Card(string suit, string value)
        {
            this.suit = suit;
            this.value = value;
           // this.center = 100;

            if (suit == "heart" || suit == "diamond")
            {
                color = Color.Red;
            } else
            {
                color = Color.Black;
            }
        }

        public override string ToString()
        {
            //TEST ♠	♥	♦	♣
            char symbol;
            if (suit == "spade")
            {
                symbol = '♠';
            }
            else if (suit == "club")
            {
                symbol = '♣';
            }
            else if (suit == "heart")
            {
                symbol = '♥';
            }
            else
            {
                symbol = '♦';
            }

            return $"{symbol} {value}";
        }

        public void Draw (Graphics g) //TODO
        {
           //Kartata
          // Brush brush = new SolidBrush(Color.LightGray);
          //  g.FillRectangle(brush, )
          //TEKST - ko kaj chip isto
        }

        public int GetValue() //TODO
        {
            //10, J, Q, K = 10
            // 1 = 1/10 ???
            return 0;
        }
    }
}
