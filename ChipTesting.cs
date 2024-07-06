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
    public partial class ChipTesting : Form
    {
        public List<Chip> Chips;
        public ChipTesting()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Chips = new List<Chip>();
        }

        private void ChipTesting_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(Color.Black);
            listBox1.Items.Add(Color.Red);
            listBox1.Items.Add(Color.Green);
            listBox1.Items.Add(Color.Blue);

            listBox1.SelectedItem = listBox1.Items[0];
        }

        private void ChipTesting_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int price = (int) numericUpDown1.Value; //Vrakja decimal - castiranje vo int
                Color color = (Color)listBox1.SelectedItem;
                Chips.Add(new Chip(price, color, e.Location));
                Invalidate();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChipTesting_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (Chips.Count > 0)
            {
                foreach (Chip chip in Chips)
                {
                    chip.Draw(g);
                }
            }
        }
    }
}
