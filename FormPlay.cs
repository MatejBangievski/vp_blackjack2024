﻿using Blackjack.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class FormPlay : Form
    {
        // Maks karti sho moze da ima = 9 (4x 2, 4x 3, 1x 1)
        public Player player; // Igrac
        public Deck deck; // Shpil karti
        public List<Card> dealerCards; // Karti na dealerot
        public List<Card> playerCards; // Karti na igracot
        public int lastWager; // Kolku vlozhil posleden pat
        public bool roundStarted; // Dali pobedil ili ne
        public List<Chip> chips; // Ke gi dodavam chipovite za draw metodot
        public int timeleft;
        public int totalWager;
        public int gamesPlayed;
        public int wonGames;

        public FormPlay()
        {
            InitializeComponent();
            DoubleBuffered = true;
            deck = new Deck();
            deck.ShuffleDeck();
            dealerCards = new List<Card>();
            playerCards = new List<Card>();
            lastWager = 0;
            totalWager = 0;
            wonGames = 0;
            gamesPlayed = 0;

            DoubleBuffered = true;
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            pb_profilepic.Image = player.profilepic;
            lbl_name.Text = player.username;
            lbl_balance.Text = $"${player.balance}";
            //Stavi max sho moze da se kocka e negoviot cel balans
            nud_wager.Maximum = player.balance;

            //Imam labeli za da zemam lokacii - gi stavam na invisible
            lbl_position1.Visible = false;
            lbl_position2.Visible = false;
            lbl_position3.Visible = false;
            lbl_position4.Visible = false;

            btn_lastbet.Visible = false;
            btn_double.Visible = false;

            GenerateChips();
        }

        private void FormPlay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (chips.Count > 0)
            {
                foreach (Chip chip in chips)
                {
                    chip.Draw(g);
                }
            }

            if (playerCards.Count > 0)
            {
                foreach (Card card in playerCards)
                {
                    card.Draw(g);
                }
            }

            if (dealerCards.Count > 0)
            {
                foreach (Card card in dealerCards)
                {
                    card.Draw(g);
                }
            }
        }

        public void GenerateChips ()
        {
            //Нацртај чипови
            //Се зима локацијата од скриените лабели
            Chip chip1 = new Chip(10, Color.Blue, lbl_position1.Location);

            Chip chip2 = new Chip(25, Color.Red, lbl_position2.Location);

            Chip chip3 = new Chip(100, Color.Purple, lbl_position3.Location);

            Chip chip4 = new Chip(1000, Color.Black, lbl_position4.Location);

            chips = new List<Chip>() { chip1, chip2, chip3, chip4 };
            Invalidate();
        }

        public void StartGame() // Kliknal na play kopceto
        {
            //Започни игра
            roundStarted = true;

            //Update на gamesplayed
            gamesPlayed++;

            //Стави колку вложил сега
            lastWager = (int)nud_wager.Value;

            //Одземи од wager
            //player.balance -= lastWager;
            //lbl_balance.Text = $"${player.balance}";

            //Ако има помалце или еднакво на 15 карти, nov deck
            if (deck.cards.Count <= 15) 
            {
                //Статистички играчот максимум може да извади 8 карти (4x2, 3x3, 1x4) а дилерот 7 (4x2, 3x3)
                deck = new Deck();
            }
            
            //Избриши чипови
            chips.Clear();

            //Стави време на 1 мин
            timer1.Start();
            timeleft = 60;

            //Избриши ги чиповите
            chips.Clear();
            Invalidate();

            //Прикажи сликичка од Dealer и име
            pb_dealer.Visible = true;
            lbl_dealername.Visible = true;
            lbl_stays.Visible = true;

            //Тргни лабели за чипови
            lbl_increase.Visible = false;
            lbl_decrease.Visible = false;

            //Приказ на копчиња
            btn_deposit.Visible = false;
            btn_exit.Visible = false;

            lbl_moneywagerd.Visible = true;
            lbl_moneywagerd.Text = lastWager + "$";

            btn_play.Enabled = false;
            btn_play.Visible = false;
            lbl_wager.Visible = false;
            nud_wager.Enabled = false;
            nud_wager.Visible = false;

            btn_hit.Visible = true;
            btn_stand.Visible = true;
            btn_hit.Enabled = true;
            btn_stand.Enabled = true;
            lb_playertotal.Visible = true;
            lb_dealertotal.Visible = true;
            lbl_timeleft.Visible = true;

            btn_lastbet.Visible = false;
            btn_double.Visible = false;

            lb_dealertotal.Text = "Total: ?";
            lb_playertotal.Text = "Total: ?";

            //Davaj karti
            timer3.Start();

        }

        public void EndGame() // Zavrshila rundata
        {
            //заврши игра
            roundStarted = false;
            timer2.Stop();

            //Стави wager na 0
            nud_wager.Maximum = player.balance;
            nud_wager.Value = 0;

            //Избриши ги картите
            playerCards.Clear();
            dealerCards.Clear();

            //Нацртај чипови
            GenerateChips();

            //Отстрани сликичка од Dealer и име
            pb_dealer.Visible = false;
            lbl_dealername.Visible = false;
            lbl_stays.Visible = false;

            //Стави лабели за чипови
            lbl_increase.Visible = true;
            lbl_decrease.Visible = true;

            //Приказ на копчиња
            btn_deposit.Visible = true;
            btn_exit.Visible = true;

            btn_play.Enabled = true;
            btn_play.Visible = true;
            lbl_wager.Visible = true;
            nud_wager.Enabled = true;
            nud_wager.Visible = true;


            lbl_moneywagerd.Visible = false;

            btn_hit.Visible = false;
            btn_stand.Visible = false;
            lb_playertotal.Visible = false;
            lb_dealertotal.Visible = false;
            lbl_timeleft.Visible = false;

            btn_lastbet.Visible = true;
            btn_double.Visible = true;


            pb_blackjack.Visible = false;
            pb_won.Visible = false;
            pb_draw.Visible = false;
            pb_lost.Visible = false;

            lbl_money.Visible = false;

            //Ako ima 0$ - deposit
            if (player.balance == 0)
            {
                if (MessageBox.Show("You don't have any money left.\n Do you want to deposit in order to play again?", "Deposit again?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DepositMoney();
                }
                else
                {
                    ExitGame();
                    this.Close();
                }
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            DepositMoney();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ExitGame();
        }

        public void DepositMoney ()
        {
            Payment newpayment = new Payment();
            newpayment.playercard = player.paymentCard;

            //Позиција во средина на овој форм
            newpayment.StartPosition = FormStartPosition.Manual;
            int centerX = this.Location.X + (this.Width / 2) - (newpayment.Width / 2);
            int centerY = this.Location.Y + (this.Height / 2) - (newpayment.Height / 2);
            newpayment.Location = new Point(centerX, centerY);
            newpayment.Location = this.Location;

            newpayment.ShowDialog();

            if (newpayment.DialogResult == DialogResult.OK)
            {
                player.paymentCard = newpayment.playercard;
                player.balance += player.paymentCard.Amount;

                //Update на лабелата и макс обложувачка
                lbl_balance.Text = $"${player.balance}";
                nud_wager.Maximum = player.balance;
            }
        }

        public void ExitGame ()
        {
            FormExit formExit = new FormExit();
            formExit.profitOrLoss = totalWager;
            formExit.totalGames = gamesPlayed;
            formExit.totalWins = wonGames;

            //Позиција во средина на овој форм
            formExit.StartPosition = FormStartPosition.Manual;
            int centerX = this.Location.X + (this.Width / 2) - (formExit.Width / 2);
            int centerY = this.Location.Y + (this.Height / 2) - (formExit.Height / 2);
            formExit.Location = new Point(centerX, centerY);
            formExit.Location = this.Location;

            this.Visible = false;
            formExit.ShowDialog();
            this.Close();
        }

        public void AddPlayerCard ()
        {
            playCardSound();
            Card card = deck.DealCard();

            //Ако е прва се зима оригиналната локација, ако не за + 1/3 (+25))
            if (playerCards.Count == 0)
            {
                card.center = lbl_playerCardPos.Location;
            } else
            {
                //Ке зголемуваме колку надесно да идеме во зависност од колку карти имаме
                int pomestuvanje = playerCards.Count * 25;
                card.center = new Point(lbl_playerCardPos.Location.X + pomestuvanje, lbl_playerCardPos.Location.Y);
            }

            playerCards.Add(card);
            lb_playertotal.Text = "Total: " + CountCardsValue(playerCards);
            Invalidate();
        }

        public void AddDealerCard()
        {
            playCardSound();
            Card card = deck.DealCard();

            //Ако е прва се зима оригиналната локација, ако не за + 1/3 (+25))
            if (dealerCards.Count == 0)
            {
                //Направи ја црна
                card.hidden = true;
                card.center = lbl_dealerCardPos.Location;
            }
            else
            {
                //Ке зголемуваме колку надесно да идеме во зависност од колку карти имаме
                int pomestuvanje = dealerCards.Count * 25;
                card.center = new Point(lbl_dealerCardPos.Location.X + pomestuvanje, lbl_dealerCardPos.Location.Y);
            }

            dealerCards.Add(card);

            Invalidate();
        }

        private void FormPlay_MouseClick(object sender, MouseEventArgs e)
        {
            // LEFT CLICK - ADD
            if (e.Button == MouseButtons.Left)
            {
                foreach (Chip chip in chips)
                {
                    if (chip.Hit(e.Location))
                    {
                        playChipSound();

                        if (nud_wager.Value + chip.Price > nud_wager.Maximum)
                        {
                            // Stavi go na najmnogu so moze
                            nud_wager.Value = nud_wager.Maximum;
                        }
                        else
                        {
                            nud_wager.Value += chip.Price;
                        }
                    }
                }
            } 
            // RIGHT CLICK - REMOVE
            else if (e.Button == MouseButtons.Right)
            {
                foreach (Chip chip in chips)
                {
                    if (chip.Hit(e.Location))
                    {
                        if (nud_wager.Value - chip.Price < nud_wager.Minimum) {
                            //Стави го на најмалку што може
                            nud_wager.Value = nud_wager.Minimum;
                        } else
                        {
                            nud_wager.Value -= chip.Price;
                        }
                    }
                }
            }

        }

        private void btn_play_Click(object sender, EventArgs e) //Започни игра
        {
            if (nud_wager.Value  > 0)
            {
                StartGame();
            }
        }

        private void btn_hit_Click(object sender, EventArgs e) //Дај ми уште една карта
        {
            AddPlayerCard();

            //Ако надминал 21 - game over
            if (CountCardsValue(playerCards) > 21)
            {
                PlayerLost();
            }    
        }


        private void btn_stand_Click(object sender, EventArgs e) //Не ми давај повеќе карти, ред е на Dealer-от
        {
            DealersTurn();
        }

        public void DealersTurn ()
        {
            btn_hit.Enabled = false;
            btn_stand.Enabled = false;
            
            //Прекини отчукување на време
            timer1.Stop();

            //Прикажи тотал
            lb_dealertotal.Text = "Total: " + CountCardsValue(dealerCards);

            //Направи ја видлива првата карта
            Card firstcard = dealerCards[0];
            firstcard.hidden = false;
            Invalidate();

            //Започни да делиш карти, а пред тоа почекај 1 секунда
            Thread.Sleep(1000);
            timer4.Start();
        }

        private void playChipSound() //При кликање на чип се прави звук.
        {
            SoundPlayer chipSound = new SoundPlayer(Properties.Resources.pokerchip_sound);
            chipSound.Play();
            chipSound.Dispose();
        }

        private void playCardSound() //При кликање на чип се прави звук.
        {
            SoundPlayer cardSound = new SoundPlayer(Properties.Resources.cardflip_sound);
            cardSound.Play();
            cardSound.Dispose();
        }

        private int CountCardsValue (List<Card> cards) // За враќање на вредноста од картите
        {
            int count = 0;
            int aces_count = 0;
            foreach (Card card in cards)
            {
                string value = card.value;
                if (value == "10" || value == "J" || value == "Q" || value == "K") 
                {
                    count += 10;
                }
                else if (value == "1") //Хендлање на случајот со 1 (може да има вредност 1/11)
                {
                    count += 11;
                    aces_count++;
                }
                else // за броеви 2 - 9
                {
                    count += int.Parse(value);
                }
            }

            //Ако count е поголемо од 21 и aces_count е повеќе/еднакво од 1 ќе намалиме
            //Во while бидејќи може да имаме повеќе единици.
            while (count > 21 && aces_count >= 1) {
                count -= 10;
                aces_count--;
            }

            return count;
        }

        private void PlayerWon (int multiplier) //Играчот ја победил рундата, се внесува multiplier
        {
            int wager = lastWager;
            int money_won = wager * multiplier;
            //Додади пари на играч
            player.balance += money_won;
            //Прикажи под balance за колку е добивката
            lbl_money.Visible = true;
            lbl_money.Text = "+" + money_won + "$";
            lbl_money.ForeColor = Color.LightGreen;

            //Слика за победа/draw
            if (multiplier == 0) //Draw
            {
                pb_draw.Visible = true;
            } else //Win
            {
                pb_won.Visible = true;

                //Update на wonGames
                wonGames++;
            }

            //Update на лабелата и макс обложувачка
            lbl_balance.Text = $"${player.balance}";
            nud_wager.Maximum = player.balance;

            //Update на totalWager
            if (multiplier == 1 || multiplier == 2)
            {
                totalWager += money_won;
            } //Ako e draw - ништо не додавај/одзимај
            

            //5 секунди па се враќа
            timer1.Stop();
            timer2.Start();

            //Тргни копчиња и timer
            btn_hit.Visible = false;
            lbl_timeleft.Visible = false;
            btn_stand.Visible = false;

            //Пушти позитивен sound effect
            SoundPlayer playerWin = new SoundPlayer(Properties.Resources.positive_beeps);
            playerWin.Play();
            playerWin.Dispose();
        }

        private void PlayerLost () 
        {
            int money_lost = lastWager;
            //Одземи пари на играч
            player.balance -= money_lost;

            //Прикажи под balance за колку е добивката
            lbl_money.Visible = true;
            lbl_money.Text = "-" + money_lost + "$";
            lbl_money.ForeColor = Color.Red;

            //Слика за пораз
            pb_lost.Visible = true;

            //Update на лабелата и макс обложувачка
            lbl_balance.Text = $"${player.balance}";
            nud_wager.Maximum = player.balance;

            //Update на totalWager
            totalWager -= money_lost;

            //5 секунди па се враќа
            timer1.Stop();
            timer2.Start();

            //Тргни копчиња и timer
            btn_hit.Visible = false;
            lbl_timeleft.Visible = false;
            btn_stand.Visible = false;

            //Пушти лош sound effect
            SoundPlayer playerLose = new SoundPlayer(Properties.Resources.negative_beeps);
            playerLose.Play();
            playerLose.Dispose();
        }

        private void btn_double_Click(object sender, EventArgs e)
        {
            //Работи како што треба, но wager се става на 0...
            if (player.balance != 0)
            {
                if (lastWager * 2 <= player.balance) //Ако има доволно, дуплирај
                {
                    nud_wager.Value = lastWager * 2;
                }
                else //Ако нема доволно, стави макс
                {
                    nud_wager.Value = player.balance;
                }
            }

            StartGame();
        }

        private void btn_lastbet_Click(object sender, EventArgs e)
        {
            if (player.balance >= lastWager && player.balance != 0)
            {
                nud_wager.Value = lastWager;
                StartGame();
            }
        }
        private void timer1_Tick(object sender, EventArgs e) //За одбројување време
        {
            //Ако играта е започната - одбројувај
            if (roundStarted)
            {
                timeleft -= 1;
                lbl_timeleft.Text = $"00:{timeleft:D2}"; //Принтај со 2 децимали

                if (timeleft <= 0)
                {
                    roundStarted = false;
                    DealersTurn();
                }
            }      
        }
        private void timer2_Tick(object sender, EventArgs e) //За откако ќе заврши играта
        {
            //После 5 секунди повикај EndGame
            timeleft = 60;
            EndGame();
        }

        private void timer3_Tick(object sender, EventArgs e) //За почеток на додавање карти
        {
            btn_hit.Enabled = false;
            btn_stand.Enabled = false;

            if (playerCards.Count == 2 && dealerCards.Count == 2) {
                //Blakjack е само ако ти се падне 21 на првите 2 карти така да тука ќе ја направам проверката.
                if (CountCardsValue(playerCards) == 21) //Blackjack!!
                {
                    pb_blackjack.Visible = true;
                    //Пушти позитивен sound effect
                    SoundPlayer playerBlackjack = new SoundPlayer(Properties.Resources.cheering_sound);
                    playerBlackjack.Play();
                    playerBlackjack.Dispose();
             
                    Thread.Sleep(3000); //Да заврши звукот
                    PlayerWon(2);
                }
                btn_hit.Enabled = true;
                btn_stand.Enabled = true;

                timer3.Stop();
            } 
            else if  (playerCards.Count == dealerCards.Count) {
                AddPlayerCard();
            } else {
                AddDealerCard();
            }
        }

        private void timer4_Tick(object sender, EventArgs e) //За Dealerot
        {
                //The Dealer must draw on 16 or less, and stand on 17 or more
                if (CountCardsValue(dealerCards) <= 16) //Dealer-от влече карта
                {
                    AddDealerCard();
                    lb_dealertotal.Text = "Total: " + CountCardsValue(dealerCards);
                }
                else
                {
                    //Проверка кој победил
                    int player_count = CountCardsValue(playerCards);

                    if ((CountCardsValue(dealerCards) > 21) || (player_count > CountCardsValue(dealerCards) && player_count <= 21)) //Победил играчот
                    {
                        PlayerWon(1);
                    }
                    else if (player_count == CountCardsValue(dealerCards) && player_count <= 21) //Draw
                    {
                        PlayerWon(0);
                    }
                    else //Победил dealer-от
                    {
                        PlayerLost();
                    }

                    timer4.Stop(); //Прекини да доделуваш
                }
            }


    }
}
