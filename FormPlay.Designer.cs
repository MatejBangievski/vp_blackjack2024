namespace Blackjack
{
    partial class FormPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.nud_wager = new System.Windows.Forms.NumericUpDown();
            this.lbl_wager = new System.Windows.Forms.Label();
            this.lbl_position1 = new System.Windows.Forms.Label();
            this.lbl_position2 = new System.Windows.Forms.Label();
            this.lbl_position4 = new System.Windows.Forms.Label();
            this.lbl_position3 = new System.Windows.Forms.Label();
            this.lbl_increase = new System.Windows.Forms.Label();
            this.lbl_decrease = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
            this.lb_playertotal = new System.Windows.Forms.Label();
            this.lb_dealertotal = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.lbl_timeleft = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_stays = new System.Windows.Forms.Label();
            this.btn_double = new System.Windows.Forms.Button();
            this.btn_lastbet = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_playerCardPos = new System.Windows.Forms.Label();
            this.lbl_dealerCardPos = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lbl_dealername = new System.Windows.Forms.Label();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pb_dealer = new System.Windows.Forms.PictureBox();
            this.pb_profilepic = new System.Windows.Forms.PictureBox();
            this.lbl_moneywagerd = new System.Windows.Forms.Label();
            this.pb_won = new System.Windows.Forms.PictureBox();
            this.pb_lost = new System.Windows.Forms.PictureBox();
            this.pb_draw = new System.Windows.Forms.PictureBox();
            this.pb_blackjack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_won)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_blackjack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_balance
            // 
            this.lbl_balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_balance.Location = new System.Drawing.Point(315, 609);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(105, 24);
            this.lbl_balance.TabIndex = 3;
            this.lbl_balance.Text = "BALANCE";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_wager
            // 
            this.nud_wager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_wager.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_wager.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_wager.Location = new System.Drawing.Point(248, 287);
            this.nud_wager.Name = "nud_wager";
            this.nud_wager.Size = new System.Drawing.Size(120, 36);
            this.nud_wager.TabIndex = 4;
            this.nud_wager.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_wager
            // 
            this.lbl_wager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_wager.AutoSize = true;
            this.lbl_wager.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wager.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_wager.Location = new System.Drawing.Point(255, 255);
            this.lbl_wager.Name = "lbl_wager";
            this.lbl_wager.Size = new System.Drawing.Size(103, 29);
            this.lbl_wager.TabIndex = 5;
            this.lbl_wager.Text = "Wager:";
            // 
            // lbl_position1
            // 
            this.lbl_position1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_position1.AutoSize = true;
            this.lbl_position1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position1.Location = new System.Drawing.Point(209, 470);
            this.lbl_position1.Name = "lbl_position1";
            this.lbl_position1.Size = new System.Drawing.Size(20, 13);
            this.lbl_position1.TabIndex = 7;
            this.lbl_position1.Text = "P1";
            // 
            // lbl_position2
            // 
            this.lbl_position2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_position2.AutoSize = true;
            this.lbl_position2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position2.Location = new System.Drawing.Point(281, 470);
            this.lbl_position2.Name = "lbl_position2";
            this.lbl_position2.Size = new System.Drawing.Size(20, 13);
            this.lbl_position2.TabIndex = 8;
            this.lbl_position2.Text = "P2";
            // 
            // lbl_position4
            // 
            this.lbl_position4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_position4.AutoSize = true;
            this.lbl_position4.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position4.Location = new System.Drawing.Point(419, 470);
            this.lbl_position4.Name = "lbl_position4";
            this.lbl_position4.Size = new System.Drawing.Size(20, 13);
            this.lbl_position4.TabIndex = 10;
            this.lbl_position4.Text = "P4";
            // 
            // lbl_position3
            // 
            this.lbl_position3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_position3.AutoSize = true;
            this.lbl_position3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position3.Location = new System.Drawing.Point(351, 470);
            this.lbl_position3.Name = "lbl_position3";
            this.lbl_position3.Size = new System.Drawing.Size(20, 13);
            this.lbl_position3.TabIndex = 9;
            this.lbl_position3.Text = "P3";
            // 
            // lbl_increase
            // 
            this.lbl_increase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_increase.AutoSize = true;
            this.lbl_increase.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_increase.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_increase.Location = new System.Drawing.Point(465, 597);
            this.lbl_increase.Name = "lbl_increase";
            this.lbl_increase.Size = new System.Drawing.Size(197, 18);
            this.lbl_increase.TabIndex = 12;
            this.lbl_increase.Text = "Left Click - Increase";
            // 
            // lbl_decrease
            // 
            this.lbl_decrease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_decrease.AutoSize = true;
            this.lbl_decrease.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_decrease.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_decrease.Location = new System.Drawing.Point(465, 625);
            this.lbl_decrease.Name = "lbl_decrease";
            this.lbl_decrease.Size = new System.Drawing.Size(206, 18);
            this.lbl_decrease.TabIndex = 13;
            this.lbl_decrease.Text = "Right Click - Decrease";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_name.Location = new System.Drawing.Point(315, 569);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 24);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "NAME";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_play.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_play.Location = new System.Drawing.Point(260, 330);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(98, 44);
            this.btn_play.TabIndex = 15;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_hit
            // 
            this.btn_hit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hit.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_hit.Location = new System.Drawing.Point(201, 320);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(94, 58);
            this.btn_hit.TabIndex = 18;
            this.btn_hit.Text = "HIT";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Visible = false;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_stand.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stand.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_stand.Location = new System.Drawing.Point(354, 320);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(96, 58);
            this.btn_stand.TabIndex = 19;
            this.btn_stand.Text = "STAND";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Visible = false;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // lb_playertotal
            // 
            this.lb_playertotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_playertotal.AutoSize = true;
            this.lb_playertotal.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playertotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_playertotal.Location = new System.Drawing.Point(256, 435);
            this.lb_playertotal.Name = "lb_playertotal";
            this.lb_playertotal.Size = new System.Drawing.Size(82, 23);
            this.lb_playertotal.TabIndex = 20;
            this.lb_playertotal.Text = "Total:";
            this.lb_playertotal.Visible = false;
            // 
            // lb_dealertotal
            // 
            this.lb_dealertotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_dealertotal.AutoSize = true;
            this.lb_dealertotal.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dealertotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_dealertotal.Location = new System.Drawing.Point(256, 213);
            this.lb_dealertotal.Name = "lb_dealertotal";
            this.lb_dealertotal.Size = new System.Drawing.Size(82, 23);
            this.lb_dealertotal.TabIndex = 21;
            this.lb_dealertotal.Text = "Total:";
            this.lb_dealertotal.Visible = false;
            // 
            // lbl_money
            // 
            this.lbl_money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_money.Location = new System.Drawing.Point(328, 633);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(75, 18);
            this.lbl_money.TabIndex = 22;
            this.lbl_money.Text = "lbl_money";
            this.lbl_money.Visible = false;
            // 
            // lbl_timeleft
            // 
            this.lbl_timeleft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_timeleft.AutoSize = true;
            this.lbl_timeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeleft.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_timeleft.Location = new System.Drawing.Point(294, 338);
            this.lbl_timeleft.Name = "lbl_timeleft";
            this.lbl_timeleft.Size = new System.Drawing.Size(60, 24);
            this.lbl_timeleft.TabIndex = 24;
            this.lbl_timeleft.Text = "00:00";
            this.lbl_timeleft.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_stays
            // 
            this.lbl_stays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_stays.AutoSize = true;
            this.lbl_stays.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stays.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_stays.Location = new System.Drawing.Point(166, 9);
            this.lbl_stays.Name = "lbl_stays";
            this.lbl_stays.Size = new System.Drawing.Size(359, 18);
            this.lbl_stays.TabIndex = 25;
            this.lbl_stays.Text = "Dealer Stands on 17, hits on 16 or less";
            this.lbl_stays.Visible = false;
            // 
            // btn_double
            // 
            this.btn_double.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_double.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_double.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_double.Location = new System.Drawing.Point(404, 323);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(98, 51);
            this.btn_double.TabIndex = 26;
            this.btn_double.Text = "DOUBLE LAST BET";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // btn_lastbet
            // 
            this.btn_lastbet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lastbet.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lastbet.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_lastbet.Location = new System.Drawing.Point(404, 255);
            this.btn_lastbet.Name = "btn_lastbet";
            this.btn_lastbet.Size = new System.Drawing.Size(98, 51);
            this.btn_lastbet.TabIndex = 27;
            this.btn_lastbet.Text = "SAME AS LAST BET";
            this.btn_lastbet.UseVisualStyleBackColor = true;
            this.btn_lastbet.Click += new System.EventHandler(this.btn_lastbet_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbl_playerCardPos
            // 
            this.lbl_playerCardPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_playerCardPos.AutoSize = true;
            this.lbl_playerCardPos.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_playerCardPos.Location = new System.Drawing.Point(241, 512);
            this.lbl_playerCardPos.Name = "lbl_playerCardPos";
            this.lbl_playerCardPos.Size = new System.Drawing.Size(28, 13);
            this.lbl_playerCardPos.TabIndex = 33;
            this.lbl_playerCardPos.Text = "PCP";
            this.lbl_playerCardPos.Visible = false;
            // 
            // lbl_dealerCardPos
            // 
            this.lbl_dealerCardPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dealerCardPos.AutoSize = true;
            this.lbl_dealerCardPos.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_dealerCardPos.Location = new System.Drawing.Point(240, 160);
            this.lbl_dealerCardPos.Name = "lbl_dealerCardPos";
            this.lbl_dealerCardPos.Size = new System.Drawing.Size(29, 13);
            this.lbl_dealerCardPos.TabIndex = 35;
            this.lbl_dealerCardPos.Text = "PCD";
            this.lbl_dealerCardPos.Visible = false;
            // 
            // timer4
            // 
            this.timer4.Interval = 800;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lbl_dealername
            // 
            this.lbl_dealername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dealername.AutoSize = true;
            this.lbl_dealername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dealername.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_dealername.Location = new System.Drawing.Point(329, 39);
            this.lbl_dealername.Name = "lbl_dealername";
            this.lbl_dealername.Size = new System.Drawing.Size(91, 24);
            this.lbl_dealername.TabIndex = 36;
            this.lbl_dealername.Text = "DEALER";
            this.lbl_dealername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dealername.Visible = false;
            // 
            // btn_deposit
            // 
            this.btn_deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deposit.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_deposit.Location = new System.Drawing.Point(186, 9);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(98, 51);
            this.btn_deposit.TabIndex = 37;
            this.btn_deposit.Text = "DEPOSIT MORE";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exit.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_exit.Location = new System.Drawing.Point(376, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 51);
            this.btn_exit.TabIndex = 38;
            this.btn_exit.Text = "QUIT GAME";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pb_dealer
            // 
            this.pb_dealer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_dealer.Image = global::Blackjack.Properties.Resources.DEALER;
            this.pb_dealer.InitialImage = global::Blackjack.Properties.Resources.PLAYER1;
            this.pb_dealer.Location = new System.Drawing.Point(244, 39);
            this.pb_dealer.MaximumSize = new System.Drawing.Size(64, 64);
            this.pb_dealer.MinimumSize = new System.Drawing.Size(64, 64);
            this.pb_dealer.Name = "pb_dealer";
            this.pb_dealer.Size = new System.Drawing.Size(64, 64);
            this.pb_dealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dealer.TabIndex = 34;
            this.pb_dealer.TabStop = false;
            this.pb_dealer.Visible = false;
            // 
            // pb_profilepic
            // 
            this.pb_profilepic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_profilepic.Image = global::Blackjack.Properties.Resources.PLAYER1;
            this.pb_profilepic.InitialImage = global::Blackjack.Properties.Resources.PLAYER1;
            this.pb_profilepic.Location = new System.Drawing.Point(244, 569);
            this.pb_profilepic.MaximumSize = new System.Drawing.Size(64, 64);
            this.pb_profilepic.MinimumSize = new System.Drawing.Size(64, 64);
            this.pb_profilepic.Name = "pb_profilepic";
            this.pb_profilepic.Size = new System.Drawing.Size(64, 64);
            this.pb_profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profilepic.TabIndex = 1;
            this.pb_profilepic.TabStop = false;
            // 
            // lbl_moneywagerd
            // 
            this.lbl_moneywagerd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_moneywagerd.AutoSize = true;
            this.lbl_moneywagerd.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moneywagerd.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_moneywagerd.Location = new System.Drawing.Point(279, 277);
            this.lbl_moneywagerd.Name = "lbl_moneywagerd";
            this.lbl_moneywagerd.Size = new System.Drawing.Size(103, 29);
            this.lbl_moneywagerd.TabIndex = 39;
            this.lbl_moneywagerd.Text = "wager$";
            this.lbl_moneywagerd.Visible = false;
            // 
            // pb_won
            // 
            this.pb_won.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_won.BackgroundImage = global::Blackjack.Properties.Resources.round_won;
            this.pb_won.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_won.Location = new System.Drawing.Point(126, 309);
            this.pb_won.Name = "pb_won";
            this.pb_won.Size = new System.Drawing.Size(409, 80);
            this.pb_won.TabIndex = 40;
            this.pb_won.TabStop = false;
            this.pb_won.Visible = false;
            // 
            // pb_lost
            // 
            this.pb_lost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_lost.BackgroundImage = global::Blackjack.Properties.Resources.round_lost;
            this.pb_lost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_lost.Location = new System.Drawing.Point(126, 309);
            this.pb_lost.Name = "pb_lost";
            this.pb_lost.Size = new System.Drawing.Size(409, 80);
            this.pb_lost.TabIndex = 41;
            this.pb_lost.TabStop = false;
            this.pb_lost.Visible = false;
            // 
            // pb_draw
            // 
            this.pb_draw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_draw.BackgroundImage = global::Blackjack.Properties.Resources.round_draw;
            this.pb_draw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_draw.Location = new System.Drawing.Point(126, 312);
            this.pb_draw.Name = "pb_draw";
            this.pb_draw.Size = new System.Drawing.Size(409, 77);
            this.pb_draw.TabIndex = 42;
            this.pb_draw.TabStop = false;
            this.pb_draw.Visible = false;
            // 
            // pb_blackjack
            // 
            this.pb_blackjack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_blackjack.BackgroundImage = global::Blackjack.Properties.Resources.blackjack_v2;
            this.pb_blackjack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_blackjack.Location = new System.Drawing.Point(186, 388);
            this.pb_blackjack.Name = "pb_blackjack";
            this.pb_blackjack.Size = new System.Drawing.Size(288, 29);
            this.pb_blackjack.TabIndex = 43;
            this.pb_blackjack.TabStop = false;
            this.pb_blackjack.Visible = false;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(685, 672);
            this.Controls.Add(this.pb_blackjack);
            this.Controls.Add(this.pb_draw);
            this.Controls.Add(this.pb_lost);
            this.Controls.Add(this.pb_won);
            this.Controls.Add(this.lbl_moneywagerd);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.lbl_dealername);
            this.Controls.Add(this.lbl_dealerCardPos);
            this.Controls.Add(this.pb_dealer);
            this.Controls.Add(this.lbl_playerCardPos);
            this.Controls.Add(this.btn_lastbet);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.lbl_stays);
            this.Controls.Add(this.lbl_timeleft);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lb_dealertotal);
            this.Controls.Add(this.lb_playertotal);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_decrease);
            this.Controls.Add(this.lbl_increase);
            this.Controls.Add(this.lbl_position4);
            this.Controls.Add(this.lbl_position3);
            this.Controls.Add(this.lbl_position2);
            this.Controls.Add(this.lbl_position1);
            this.Controls.Add(this.pb_profilepic);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_wager);
            this.Controls.Add(this.nud_wager);
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPlay_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormPlay_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.nud_wager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_won)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_blackjack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_profilepic;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.NumericUpDown nud_wager;
        private System.Windows.Forms.Label lbl_wager;
        private System.Windows.Forms.Label lbl_position1;
        private System.Windows.Forms.Label lbl_position2;
        private System.Windows.Forms.Label lbl_position4;
        private System.Windows.Forms.Label lbl_position3;
        private System.Windows.Forms.Label lbl_increase;
        private System.Windows.Forms.Label lbl_decrease;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stand;
        private System.Windows.Forms.Label lb_playertotal;
        private System.Windows.Forms.Label lb_dealertotal;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label lbl_timeleft;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_stays;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Button btn_lastbet;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbl_playerCardPos;
        private System.Windows.Forms.PictureBox pb_dealer;
        private System.Windows.Forms.Label lbl_dealerCardPos;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lbl_dealername;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_moneywagerd;
        private System.Windows.Forms.PictureBox pb_won;
        private System.Windows.Forms.PictureBox pb_lost;
        private System.Windows.Forms.PictureBox pb_draw;
        private System.Windows.Forms.PictureBox pb_blackjack;
    }
}