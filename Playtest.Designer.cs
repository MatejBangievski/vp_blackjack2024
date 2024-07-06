namespace Blackjack
{
    partial class Playtest
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
            this.pb_profilepic = new System.Windows.Forms.PictureBox();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.nud_wager = new System.Windows.Forms.NumericUpDown();
            this.lbl_wager = new System.Windows.Forms.Label();
            this.lbl_position1 = new System.Windows.Forms.Label();
            this.lbl_position2 = new System.Windows.Forms.Label();
            this.lbl_position4 = new System.Windows.Forms.Label();
            this.lbl_position3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_playercards = new System.Windows.Forms.ListBox();
            this.lb_dealercards = new System.Windows.Forms.ListBox();
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
            this.lb_playertotal = new System.Windows.Forms.Label();
            this.lb_dealertotal = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.lbl_blackjack = new System.Windows.Forms.Label();
            this.lbl_timeleft = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_stays = new System.Windows.Forms.Label();
            this.btn_double = new System.Windows.Forms.Button();
            this.btn_lastbet = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_roundResult = new System.Windows.Forms.Label();
            this.lbl_totalwager = new System.Windows.Forms.Label();
            this.lbl_totalgames = new System.Windows.Forms.Label();
            this.lbl_gameswon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wager)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_profilepic
            // 
            this.pb_profilepic.Image = global::Blackjack.Properties.Resources.PLAYER1;
            this.pb_profilepic.InitialImage = global::Blackjack.Properties.Resources.PLAYER1;
            this.pb_profilepic.Location = new System.Drawing.Point(258, 515);
            this.pb_profilepic.MaximumSize = new System.Drawing.Size(64, 64);
            this.pb_profilepic.MinimumSize = new System.Drawing.Size(64, 64);
            this.pb_profilepic.Name = "pb_profilepic";
            this.pb_profilepic.Size = new System.Drawing.Size(64, 64);
            this.pb_profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profilepic.TabIndex = 1;
            this.pb_profilepic.TabStop = false;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_balance.Location = new System.Drawing.Point(329, 555);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(105, 24);
            this.lbl_balance.TabIndex = 3;
            this.lbl_balance.Text = "BALANCE";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_wager
            // 
            this.nud_wager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_wager.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_wager.Location = new System.Drawing.Point(285, 307);
            this.nud_wager.Name = "nud_wager";
            this.nud_wager.Size = new System.Drawing.Size(120, 26);
            this.nud_wager.TabIndex = 4;
            this.nud_wager.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_wager
            // 
            this.lbl_wager.AutoSize = true;
            this.lbl_wager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wager.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_wager.Location = new System.Drawing.Point(300, 280);
            this.lbl_wager.Name = "lbl_wager";
            this.lbl_wager.Size = new System.Drawing.Size(77, 24);
            this.lbl_wager.TabIndex = 5;
            this.lbl_wager.Text = "Wager:";
            // 
            // lbl_position1
            // 
            this.lbl_position1.AutoSize = true;
            this.lbl_position1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position1.Location = new System.Drawing.Point(233, 441);
            this.lbl_position1.Name = "lbl_position1";
            this.lbl_position1.Size = new System.Drawing.Size(20, 13);
            this.lbl_position1.TabIndex = 7;
            this.lbl_position1.Text = "P1";
            // 
            // lbl_position2
            // 
            this.lbl_position2.AutoSize = true;
            this.lbl_position2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position2.Location = new System.Drawing.Point(305, 441);
            this.lbl_position2.Name = "lbl_position2";
            this.lbl_position2.Size = new System.Drawing.Size(20, 13);
            this.lbl_position2.TabIndex = 8;
            this.lbl_position2.Text = "P2";
            // 
            // lbl_position4
            // 
            this.lbl_position4.AutoSize = true;
            this.lbl_position4.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position4.Location = new System.Drawing.Point(443, 441);
            this.lbl_position4.Name = "lbl_position4";
            this.lbl_position4.Size = new System.Drawing.Size(20, 13);
            this.lbl_position4.TabIndex = 10;
            this.lbl_position4.Text = "P4";
            // 
            // lbl_position3
            // 
            this.lbl_position3.AutoSize = true;
            this.lbl_position3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position3.Location = new System.Drawing.Point(375, 441);
            this.lbl_position3.Name = "lbl_position3";
            this.lbl_position3.Size = new System.Drawing.Size(20, 13);
            this.lbl_position3.TabIndex = 9;
            this.lbl_position3.Text = "P3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(512, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Left Click - Increase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(512, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Right Click - Decrease";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_name.Location = new System.Drawing.Point(329, 515);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 24);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "NAME";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(297, 339);
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
            // lb_playercards
            // 
            this.lb_playercards.FormattingEnabled = true;
            this.lb_playercards.Location = new System.Drawing.Point(47, 445);
            this.lb_playercards.Name = "lb_playercards";
            this.lb_playercards.Size = new System.Drawing.Size(77, 134);
            this.lb_playercards.TabIndex = 16;
            this.lb_playercards.Visible = false;
            // 
            // lb_dealercards
            // 
            this.lb_dealercards.FormattingEnabled = true;
            this.lb_dealercards.Location = new System.Drawing.Point(47, 27);
            this.lb_dealercards.Name = "lb_dealercards";
            this.lb_dealercards.Size = new System.Drawing.Size(77, 134);
            this.lb_dealercards.TabIndex = 17;
            this.lb_dealercards.Visible = false;
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(12, 307);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(54, 58);
            this.btn_hit.TabIndex = 18;
            this.btn_hit.Text = "HIT";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Visible = false;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.Location = new System.Drawing.Point(101, 307);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(54, 58);
            this.btn_stand.TabIndex = 19;
            this.btn_stand.Text = "STAND";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Visible = false;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // lb_playertotal
            // 
            this.lb_playertotal.AutoSize = true;
            this.lb_playertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playertotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_playertotal.Location = new System.Drawing.Point(47, 418);
            this.lb_playertotal.Name = "lb_playertotal";
            this.lb_playertotal.Size = new System.Drawing.Size(62, 24);
            this.lb_playertotal.TabIndex = 20;
            this.lb_playertotal.Text = "Total:";
            this.lb_playertotal.Visible = false;
            // 
            // lb_dealertotal
            // 
            this.lb_dealertotal.AutoSize = true;
            this.lb_dealertotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dealertotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_dealertotal.Location = new System.Drawing.Point(47, 164);
            this.lb_dealertotal.Name = "lb_dealertotal";
            this.lb_dealertotal.Size = new System.Drawing.Size(62, 24);
            this.lb_dealertotal.TabIndex = 21;
            this.lb_dealertotal.Text = "Total:";
            this.lb_dealertotal.Visible = false;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_money.Location = new System.Drawing.Point(342, 579);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(75, 18);
            this.lbl_money.TabIndex = 22;
            this.lbl_money.Text = "lbl_money";
            this.lbl_money.Visible = false;
            // 
            // lbl_blackjack
            // 
            this.lbl_blackjack.AutoSize = true;
            this.lbl_blackjack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blackjack.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_blackjack.Location = new System.Drawing.Point(273, 240);
            this.lbl_blackjack.Name = "lbl_blackjack";
            this.lbl_blackjack.Size = new System.Drawing.Size(144, 24);
            this.lbl_blackjack.TabIndex = 23;
            this.lbl_blackjack.Text = "BLACKJACK!!!";
            this.lbl_blackjack.Visible = false;
            // 
            // lbl_timeleft
            // 
            this.lbl_timeleft.AutoSize = true;
            this.lbl_timeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeleft.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_timeleft.Location = new System.Drawing.Point(49, 271);
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
            this.lbl_stays.AutoSize = true;
            this.lbl_stays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stays.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_stays.Location = new System.Drawing.Point(201, 9);
            this.lbl_stays.Name = "lbl_stays";
            this.lbl_stays.Size = new System.Drawing.Size(302, 18);
            this.lbl_stays.TabIndex = 25;
            this.lbl_stays.Text = "Dealer Stands on 17, hits on 16 or less";
            // 
            // btn_double
            // 
            this.btn_double.Location = new System.Drawing.Point(436, 335);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(86, 34);
            this.btn_double.TabIndex = 26;
            this.btn_double.Text = "DOUBLE LAST BET";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // btn_lastbet
            // 
            this.btn_lastbet.Location = new System.Drawing.Point(436, 299);
            this.btn_lastbet.Name = "btn_lastbet";
            this.btn_lastbet.Size = new System.Drawing.Size(86, 34);
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
            // lbl_roundResult
            // 
            this.lbl_roundResult.AutoSize = true;
            this.lbl_roundResult.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roundResult.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_roundResult.Location = new System.Drawing.Point(195, 190);
            this.lbl_roundResult.Name = "lbl_roundResult";
            this.lbl_roundResult.Size = new System.Drawing.Size(369, 50);
            this.lbl_roundResult.TabIndex = 28;
            this.lbl_roundResult.Text = "ROUND WON/LOST";
            this.lbl_roundResult.Visible = false;
            // 
            // lbl_totalwager
            // 
            this.lbl_totalwager.AutoSize = true;
            this.lbl_totalwager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalwager.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_totalwager.Location = new System.Drawing.Point(281, 27);
            this.lbl_totalwager.Name = "lbl_totalwager";
            this.lbl_totalwager.Size = new System.Drawing.Size(149, 24);
            this.lbl_totalwager.TabIndex = 29;
            this.lbl_totalwager.Text = "total profit/loss:";
            // 
            // lbl_totalgames
            // 
            this.lbl_totalgames.AutoSize = true;
            this.lbl_totalgames.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_totalgames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalgames.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_totalgames.Location = new System.Drawing.Point(594, 9);
            this.lbl_totalgames.Name = "lbl_totalgames";
            this.lbl_totalgames.Size = new System.Drawing.Size(96, 16);
            this.lbl_totalgames.TabIndex = 30;
            this.lbl_totalgames.Text = "Total games: 0";
            // 
            // lbl_gameswon
            // 
            this.lbl_gameswon.AutoSize = true;
            this.lbl_gameswon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameswon.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_gameswon.Location = new System.Drawing.Point(594, 27);
            this.lbl_gameswon.Name = "lbl_gameswon";
            this.lbl_gameswon.Size = new System.Drawing.Size(80, 16);
            this.lbl_gameswon.TabIndex = 31;
            this.lbl_gameswon.Text = "Total wins: 0";
            // 
            // Playtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(698, 610);
            this.Controls.Add(this.lbl_gameswon);
            this.Controls.Add(this.lbl_totalgames);
            this.Controls.Add(this.lbl_totalwager);
            this.Controls.Add(this.lbl_roundResult);
            this.Controls.Add(this.btn_lastbet);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.lbl_stays);
            this.Controls.Add(this.lbl_timeleft);
            this.Controls.Add(this.lbl_blackjack);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lb_dealertotal);
            this.Controls.Add(this.lb_playertotal);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.lb_dealercards);
            this.Controls.Add(this.lb_playercards);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_position4);
            this.Controls.Add(this.lbl_position3);
            this.Controls.Add(this.lbl_position2);
            this.Controls.Add(this.lbl_position1);
            this.Controls.Add(this.pb_profilepic);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_wager);
            this.Controls.Add(this.nud_wager);
            this.Name = "Playtest";
            this.Text = "Playtest";
            this.Load += new System.EventHandler(this.Playtest_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Playtest_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Playtest_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wager)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lb_playercards;
        private System.Windows.Forms.ListBox lb_dealercards;
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stand;
        private System.Windows.Forms.Label lb_playertotal;
        private System.Windows.Forms.Label lb_dealertotal;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label lbl_blackjack;
        private System.Windows.Forms.Label lbl_timeleft;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_stays;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Button btn_lastbet;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbl_roundResult;
        private System.Windows.Forms.Label lbl_totalwager;
        private System.Windows.Forms.Label lbl_totalgames;
        private System.Windows.Forms.Label lbl_gameswon;
    }
}