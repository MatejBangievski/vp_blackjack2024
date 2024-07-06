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
            this.nud_wager.Location = new System.Drawing.Point(289, 364);
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
            this.lbl_wager.Location = new System.Drawing.Point(304, 337);
            this.lbl_wager.Name = "lbl_wager";
            this.lbl_wager.Size = new System.Drawing.Size(77, 24);
            this.lbl_wager.TabIndex = 5;
            this.lbl_wager.Text = "Wager:";
            // 
            // lbl_position1
            // 
            this.lbl_position1.AutoSize = true;
            this.lbl_position1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_position1.Location = new System.Drawing.Point(218, 441);
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
            this.lbl_position4.Location = new System.Drawing.Point(450, 441);
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
            this.lbl_name.Location = new System.Drawing.Point(328, 515);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 24);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "NAME";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Playtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(698, 610);
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
    }
}