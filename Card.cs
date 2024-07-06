using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public class Card
    {
        public string suit {  get; set; }
        public char symbol { get; set; } //Suit во текстуален приказ
        public Color color { get; set; }
        public string value { get; set; } // String поради J, Q, K
        public bool hidden { get; set; } //Кај dealer-от дали ќе е видлива или не
        public Point center { get; set; } //Центар на картата

        public Card(string suit, string value) //Овој конструктор ќе се користи за Deck
        {
            this.suit = suit;
            this.value = value;

            if (suit == "heart" || suit == "diamond")
            {
                color = Color.Red;
            } else
            {
                color = Color.Black;
            }

            //TEST ♠	♥	♦	♣
            if (suit == "spade")
            {
                this.symbol = '♠';
            }
            else if (suit == "club")
            {
                this.symbol = '♣';
            }
            else if (suit == "heart")
            {
                this.symbol = '♥';
            }
            else
            {
                this.symbol = '♦';
            }

            this.hidden = false;
        }

        public override string ToString()
        {
            return $"{symbol} {value}";
        }

        public void Draw (Graphics g) //TODO
        {
            int height = 90;
            int width = 60;

            if (this.hidden)
            {
                //Цртање карта - цела црна
                Brush brush = new SolidBrush(Color.Black);
                g.FillRectangle(brush, center.X - width / 2, center.Y - height / 2, width, height);
                brush.Dispose();
            } else
            {
                //Цртање карта - бела позадина
                Brush brush = new SolidBrush(Color.GhostWhite);
                g.FillRectangle(brush, center.X - width / 2, center.Y - height / 2, width, height);
                brush.Dispose();

                //Цртанје - црна рамка
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen,center.X - width / 2, center.Y - height / 2, width, height);
                pen.Dispose();

                //Дефинирај фонт за карта - соодветна боја
                Font font = new Font("Arial", 12);
                Brush textBrush = new SolidBrush(color);

                // Calculate positions for text
                SizeF valueSize = g.MeasureString(value, font);
                SizeF symbolSize = g.MeasureString(symbol.ToString(), font);
                PointF topLeft = new PointF(center.X - width / 2 + 5, center.Y - height / 2 + 5);
                PointF bottomRight = new PointF(center.X + width / 2 - valueSize.Width - 5, center.Y + height / 2 - valueSize.Height - 5);
                PointF middle = new PointF(center.X - symbolSize.Width / 2, center.Y - symbolSize.Height / 2);

                // Draw the value in the top-left corner
                g.DrawString(value, font, textBrush, topLeft);

                // Draw the value in the bottom-right corner
                g.DrawString(value, font, textBrush, bottomRight);

                // Draw the suit symbol in the middle
                g.DrawString(symbol.ToString(), font, textBrush, middle);

                font.Dispose();
                textBrush.Dispose();
            }
        }
    }
}
