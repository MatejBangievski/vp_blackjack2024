using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Chip
    {
        public int Price { get; set; }
        public Color Color { get; set; }
        public Point Center { get; set; }

        public Chip(int price, Color color, Point center)
        {
            Price = price;
            Color = color;
            Center = center;
        }

        public void Draw (Graphics g) //Crtanje 
        {   
            /* Default size: 50
             Border - spored bojata - isprekinato
             Boja - bela i nekako da pisuva cena vo sredina */

            //Sredinata
            Brush brush_white = new SolidBrush(Color.White);
            g.FillEllipse(brush_white, Center.X - 25, Center.Y - 25, 50, 50);
            brush_white.Dispose();

            //Border
            Pen pen_border = new Pen(Color, 3);
            pen_border.DashStyle = DashStyle.Dash;
            g.DrawEllipse(pen_border, Center.X - 25, Center.Y - 25, 50, 50);
            pen_border.Dispose();

            // Text
            Brush brush_black = new SolidBrush(Color.Black);
            // Treba nekako da se presmeta shirinata na tesktot - GPT
            Font font = new Font("Arial", 15);
            SizeF textSize = g.MeasureString(Price.ToString(), font);
            //// Calculate the position to center the text
            g.DrawString(Price.ToString(), font, brush_black, Center.X - (textSize.Width/2), Center.Y - (textSize.Height/2));
            brush_black.Dispose();
        }

        public bool Hit(Point point)
        {
            return Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) < 25;
        }

    }
}
