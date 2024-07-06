namespace Blackjack
{
    partial class FormMain
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_testing = new System.Windows.Forms.Button();
            this.btn_mutesounds = new System.Windows.Forms.Button();
            this.lbl_playDescription = new System.Windows.Forms.Label();
            this.lbl_testingDescription = new System.Windows.Forms.Label();
            this.lbl_muteDectiption = new System.Windows.Forms.Label();
            this.pb_blackjack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_blackjack)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_play.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_play.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.Indigo;
            this.btn_play.Location = new System.Drawing.Point(279, 180);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(94, 39);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "PLAY";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseEnter += new System.EventHandler(this.btn_play_MouseEnter);
            this.btn_play.MouseLeave += new System.EventHandler(this.btn_play_MouseLeave);
            // 
            // btn_testing
            // 
            this.btn_testing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_testing.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testing.ForeColor = System.Drawing.Color.Indigo;
            this.btn_testing.Location = new System.Drawing.Point(279, 250);
            this.btn_testing.Name = "btn_testing";
            this.btn_testing.Size = new System.Drawing.Size(94, 39);
            this.btn_testing.TabIndex = 3;
            this.btn_testing.Text = "TESTING";
            this.btn_testing.UseVisualStyleBackColor = true;
            this.btn_testing.Click += new System.EventHandler(this.btn_testing_Click);
            this.btn_testing.MouseEnter += new System.EventHandler(this.btn_testing_MouseEnter);
            this.btn_testing.MouseLeave += new System.EventHandler(this.btn_testing_MouseLeave);
            // 
            // btn_mutesounds
            // 
            this.btn_mutesounds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mutesounds.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mutesounds.ForeColor = System.Drawing.Color.Indigo;
            this.btn_mutesounds.Location = new System.Drawing.Point(279, 318);
            this.btn_mutesounds.Name = "btn_mutesounds";
            this.btn_mutesounds.Size = new System.Drawing.Size(94, 39);
            this.btn_mutesounds.TabIndex = 4;
            this.btn_mutesounds.Text = "MUTE";
            this.btn_mutesounds.UseVisualStyleBackColor = true;
            this.btn_mutesounds.Click += new System.EventHandler(this.btn_mutesounds_Click);
            this.btn_mutesounds.MouseEnter += new System.EventHandler(this.btn_mutesounds_MouseEnter);
            this.btn_mutesounds.MouseLeave += new System.EventHandler(this.btn_mutesounds_MouseLeave);
            // 
            // lbl_playDescription
            // 
            this.lbl_playDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_playDescription.AutoSize = true;
            this.lbl_playDescription.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_playDescription.Location = new System.Drawing.Point(379, 188);
            this.lbl_playDescription.Name = "lbl_playDescription";
            this.lbl_playDescription.Size = new System.Drawing.Size(251, 18);
            this.lbl_playDescription.TabIndex = 5;
            this.lbl_playDescription.Text = "Start a new Blackjack game!";
            this.lbl_playDescription.Visible = false;
            // 
            // lbl_testingDescription
            // 
            this.lbl_testingDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_testingDescription.AutoSize = true;
            this.lbl_testingDescription.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_testingDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_testingDescription.Location = new System.Drawing.Point(379, 258);
            this.lbl_testingDescription.Name = "lbl_testingDescription";
            this.lbl_testingDescription.Size = new System.Drawing.Size(233, 18);
            this.lbl_testingDescription.TabIndex = 6;
            this.lbl_testingDescription.Text = "Test some functionalities";
            this.lbl_testingDescription.Visible = false;
            // 
            // lbl_muteDectiption
            // 
            this.lbl_muteDectiption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_muteDectiption.AutoSize = true;
            this.lbl_muteDectiption.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_muteDectiption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_muteDectiption.Location = new System.Drawing.Point(379, 326);
            this.lbl_muteDectiption.Name = "lbl_muteDectiption";
            this.lbl_muteDectiption.Size = new System.Drawing.Size(98, 18);
            this.lbl_muteDectiption.TabIndex = 7;
            this.lbl_muteDectiption.Text = "Mute music";
            this.lbl_muteDectiption.Visible = false;
            // 
            // pb_blackjack
            // 
            this.pb_blackjack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_blackjack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_blackjack.Image = global::Blackjack.Properties.Resources.blackjack_v2;
            this.pb_blackjack.Location = new System.Drawing.Point(165, 67);
            this.pb_blackjack.Name = "pb_blackjack";
            this.pb_blackjack.Size = new System.Drawing.Size(337, 60);
            this.pb_blackjack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_blackjack.TabIndex = 9;
            this.pb_blackjack.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(699, 481);
            this.Controls.Add(this.pb_blackjack);
            this.Controls.Add(this.lbl_muteDectiption);
            this.Controls.Add(this.lbl_testingDescription);
            this.Controls.Add(this.lbl_playDescription);
            this.Controls.Add(this.btn_mutesounds);
            this.Controls.Add(this.btn_testing);
            this.Controls.Add(this.btn_play);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_blackjack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_testing;
        private System.Windows.Forms.Button btn_mutesounds;
        private System.Windows.Forms.Label lbl_playDescription;
        private System.Windows.Forms.Label lbl_testingDescription;
        private System.Windows.Forms.Label lbl_muteDectiption;
        private System.Windows.Forms.PictureBox pb_blackjack;
    }
}

