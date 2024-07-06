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
    /* 
     * NE GI BRISEME OVIE - KO DA IMAME U DOKUMENTOT DA STAVAME SO SME PRAVELE (✓) - napraveno
     * TUKA KE NAVEDUVAM IDEI
     * Treba nekakov algoritam za Dealerot (ako ima pomalce od tebe da vleze karta, ako ima povekje - prekini)
     * Crtanje na karti, na sekoj hit (daj mi use edna karta) nekako ke treba da se pomestuvaat 
     * Ednata karta na dealerot e skriena
     * Balance sistem - userot da ima pari, i kolku ke vrakja na pobeda
     * Na pobeda da ima nekoj efekt ko da se prikaze na sredina kolku pari si dobil/izgubil pa da te vrati nazad
     * Chipovite da se na soodvetni koordinati (kartite isto..)
     * Site formi so ke gi pravime da se ista golemina za da izgleda ko da se prefrlas od edno na drugo meni
     * POZADINA: ke se menuva od vreme na vreme demek trepka dealerot - koga ke pobedis :), izgubis :/
     * POZADINA: demek ti dava karta edna slika, pa na sam sebe druga
     * BALANCE: Ako iskocka se, MessageBox dali saka da stavi pari ili da izgasi?
     * Posle izigrana runda opcija za double na proshliot wager?
     * 
     * PROBLEM:
     * ✓ Kako da napravime od edna forma na druga da se prebacuvame? treba da e na isto mesto da se napravi a ne gore levo
     * 1 moze da bide 1 ili 11, kako da go implementirame ova?
     */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void deckTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeckTest deckTest = new DeckTest();
            //Pozicijata da e ista ko na ovoj form
            deckTest.StartPosition = FormStartPosition.Manual;
            deckTest.Location = this.Location;

            //VISIBLE - ja pravi nevidliva prvichnata forma. Efekt demek se zatvara
            this.Visible = false;
            deckTest.ShowDialog();
            this.Visible = true;
        }

        private void chipTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChipTesting chipTesting = new ChipTesting();
            //Pozicijata da e ista ko na ovoj form
            chipTesting.StartPosition = FormStartPosition.Manual;
            chipTesting.Location = this.Location;

            //VISIBLE - ja pravi nevidliva prvichnata forma. Efekt demek se zatvara
            this.Visible = false;
            chipTesting.ShowDialog();
            this.Visible = true;
        }

        private void userCreationTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usercreation usercreation = new Usercreation();
            //Pozicijata da e ista ko na ovoj form
            usercreation.StartPosition = FormStartPosition.Manual;
            usercreation.Location = this.Location;

            //VISIBLE - ja pravi nevidliva prvichnata forma. Efekt demek se zatvara
            this.Visible = false;
            usercreation.ShowDialog();
            this.Visible = true;
        }
        
    }
}
