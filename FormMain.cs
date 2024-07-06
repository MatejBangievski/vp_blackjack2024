using Blackjack.Properties;
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

namespace Blackjack
{
    /* 
     * NE GI BRISEME OVIE - KO DA IMAME U DOKUMENTOT DA STAVAME SO SME PRAVELE (✓) - napraveno
     * TUKA KE NAVEDUVAM IDEI
     * ✓ Treba nekakov algoritam za Dealerot (ako ima pomalce od tebe da vleze karta, ako ima povekje - prekini)
     * ✓ Crtanje na karti, na sekoj hit (daj mi use edna karta) nekako ke treba da se pomestuvaat 
     * ✓ Ednata karta na dealerot e skriena
     * ✓ Balance sistem - userot da ima pari, i kolku ke vrakja na pobeda
     * ✓ Na pobeda da ima nekoj efekt ko da se prikaze na sredina kolku pari si dobil/izgubil pa da te vrati nazad
     * ✓ Chipovite da se na soodvetni koordinati (kartite isto..)
     * ✓ Site formi so ke gi pravime da se ista golemina za da izgleda ko da se prefrlas od edno na drugo meni
     * X POZADINA: ke se menuva od vreme na vreme demek trepka dealerot - koga ke pobedis :), izgubis :/
     * X POZADINA: demek ti dava karta edna slika, pa na sam sebe druga
     * ✓ BALANCE: Ako iskocka se, MessageBox dali saka da stavi pari ili da izgasi?
     * ✓ Posle izigrana runda opcija za double na proshliot wager?
     * ✓ Moze nekakvi audio efekti da se dodadat
     * 
     * PROBLEM:
     * ✓ Kako da napravime od edna forma na druga da se prebacuvame? treba da e na isto mesto da se napravi a ne gore levo
     * ✓ moze da bide 1 ili 11, kako da go implementirame ova?
     */


    public partial class FormMain : Form
    {
        //Треба да се додаде музиката во Resources.resx
        public SoundPlayer menuMusic;
        public bool muteEnabled;

        public FormMain()
        {
            InitializeComponent();
            muteEnabled = false;
            menuMusic = new SoundPlayer(Properties.Resources.mainmenu_music); //Се зима музиката од Resrources
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Да започне музиката
            menuMusic.PlayLooping();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            //Прекини ја музиката ако е пуштена
            if (!muteEnabled)
            {
                menuMusic.Stop();
            }

            FormCreation creationForm = new FormCreation();
            //Позицијата да е иста ко на овој form
            creationForm.StartPosition = FormStartPosition.Manual;

            int centerX = this.Location.X + (this.Width / 2) - (creationForm.Width / 2);
            int centerY = this.Location.Y + (this.Height / 2) - (creationForm.Height / 2);
            creationForm.Location = new Point(centerX, centerY);
            creationForm.Location = this.Location;

            //Изгаси ја формава, со VISIBLE ќе направиме да изгледа како одма да се изгасила
            this.Visible = false;
            creationForm.ShowDialog();
            this.Close();

            //Продолжи со музиката ако е пуштена
            if (!muteEnabled)
            {
                menuMusic.PlayLooping();
            }
        }

        private void btn_testing_Click(object sender, EventArgs e)
        {

            //Прекини ја музиката ако е пуштена
            if (!muteEnabled)
            {
                menuMusic.Stop();
            }

            FormTesting testingForm = new FormTesting();
            //Позицијата да е иста ко на овој form
            testingForm.StartPosition = FormStartPosition.Manual;

            int centerX = this.Location.X + (this.Width / 2) - (testingForm.Width / 2);
            int centerY = this.Location.Y + (this.Height / 2) - (testingForm.Height / 2);
            testingForm.Location = new Point(centerX, centerY);

            //VISIBLE - ја прави невидлива оваа форма. Целта е да се постигне поинтерактивен ефект
            this.Visible = false;
            testingForm.ShowDialog();
            this.Visible = true;

            //Продолжи со музиката ако е пуштена
            if (!muteEnabled)
            {
                menuMusic.PlayLooping();
            }
        }

        private void btn_mutesounds_Click(object sender, EventArgs e)
        {

            muteEnabled = (!muteEnabled);
            //Promeni ikona
            if (muteEnabled) //Прекини ја песната
            {
                btn_mutesounds.Text = "UNMUTE";
                menuMusic.Stop();
            } else //Пушти ја песната
            {
                btn_mutesounds.Text = "MUTE";
                menuMusic.PlayLooping();
            }
        }

        //Enter и Leave за копчето Play - прикажи опис за копчето
        private void btn_play_MouseEnter(object sender, EventArgs e)
        {
            //Покажи објаснување
            lbl_playDescription.Visible = true;

            //Смени изглед во празно
            btn_play.ForeColor = Color.GhostWhite;
            btn_play.BackColor = Color.Indigo;
        }
        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            //Отстрани објаснување
            lbl_playDescription.Visible = false;

            //Смени изглед во полно
            btn_play.ForeColor = Color.Indigo;
            btn_play.BackColor = Color.GhostWhite;
        }

        //Hover и Leave за копчето Testing - прикажи опис за копчето
        private void btn_testing_MouseEnter(object sender, EventArgs e)
        {
            //Покажи објаснување
            lbl_testingDescription.Visible = true;

            //Смени изглед во празно
            btn_testing.ForeColor = Color.GhostWhite;
            btn_testing.BackColor = Color.Indigo;
        }
        private void btn_testing_MouseLeave(object sender, EventArgs e)
        {
            //Отстрани објаснување
            lbl_testingDescription.Visible= false;

            //Смени изглед во полно
            btn_testing.ForeColor = Color.Indigo;
            btn_testing.BackColor = Color.GhostWhite;
        }

        //Hover и Leave за копчето Mute - прикажи опис за копчето
        private void btn_mutesounds_MouseEnter(object sender, EventArgs e)
        {
            //Покажи објаснување
            lbl_muteDectiption.Visible = true;

            //Смени изглед во празно
            btn_mutesounds.ForeColor = Color.GhostWhite;
            btn_mutesounds.BackColor = Color.Indigo;
        }
        private void btn_mutesounds_MouseLeave(object sender, EventArgs e)
        {
            //Отстрани објаснување
            lbl_muteDectiption.Visible = false;

            //Смени изглед во полно
            btn_mutesounds.ForeColor = Color.Indigo;
            btn_mutesounds.BackColor = Color.GhostWhite;
        }
    }
}
