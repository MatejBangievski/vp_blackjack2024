namespace Blackjack
{
    partial class FormTesting
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
            this.btn_deck = new System.Windows.Forms.Button();
            this.btn_chips = new System.Windows.Forms.Button();
            this.btn_demo = new System.Windows.Forms.Button();
            this.lbl_deck = new System.Windows.Forms.Label();
            this.lbl_chips = new System.Windows.Forms.Label();
            this.lbl_demo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deck
            // 
            this.btn_deck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deck.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deck.ForeColor = System.Drawing.Color.Indigo;
            this.btn_deck.Location = new System.Drawing.Point(30, 30);
            this.btn_deck.Name = "btn_deck";
            this.btn_deck.Size = new System.Drawing.Size(102, 49);
            this.btn_deck.TabIndex = 0;
            this.btn_deck.Text = "PLAYING CARDS DECK";
            this.btn_deck.UseVisualStyleBackColor = true;
            this.btn_deck.Click += new System.EventHandler(this.btn_deck_Click);
            this.btn_deck.MouseEnter += new System.EventHandler(this.btn_deck_MouseEnter);
            this.btn_deck.MouseLeave += new System.EventHandler(this.btn_deck_MouseLeave);
            // 
            // btn_chips
            // 
            this.btn_chips.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chips.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chips.ForeColor = System.Drawing.Color.Indigo;
            this.btn_chips.Location = new System.Drawing.Point(30, 102);
            this.btn_chips.Name = "btn_chips";
            this.btn_chips.Size = new System.Drawing.Size(102, 49);
            this.btn_chips.TabIndex = 1;
            this.btn_chips.Text = "CHIPS";
            this.btn_chips.UseVisualStyleBackColor = true;
            this.btn_chips.Click += new System.EventHandler(this.btn_chips_Click);
            this.btn_chips.MouseEnter += new System.EventHandler(this.btn_chips_MouseEnter);
            this.btn_chips.MouseLeave += new System.EventHandler(this.btn_chips_MouseLeave);
            // 
            // btn_demo
            // 
            this.btn_demo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_demo.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demo.ForeColor = System.Drawing.Color.Indigo;
            this.btn_demo.Location = new System.Drawing.Point(30, 180);
            this.btn_demo.Name = "btn_demo";
            this.btn_demo.Size = new System.Drawing.Size(102, 49);
            this.btn_demo.TabIndex = 2;
            this.btn_demo.Text = "GAME DEMO";
            this.btn_demo.UseVisualStyleBackColor = true;
            this.btn_demo.Click += new System.EventHandler(this.btn_demo_Click);
            this.btn_demo.MouseEnter += new System.EventHandler(this.btn_demo_MouseEnter);
            this.btn_demo.MouseLeave += new System.EventHandler(this.btn_demo_MouseLeave);
            // 
            // lbl_deck
            // 
            this.lbl_deck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_deck.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deck.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_deck.Location = new System.Drawing.Point(138, 33);
            this.lbl_deck.Name = "lbl_deck";
            this.lbl_deck.Size = new System.Drawing.Size(276, 46);
            this.lbl_deck.TabIndex = 3;
            this.lbl_deck.Text = "Test one deck of cards with its methods";
            // 
            // lbl_chips
            // 
            this.lbl_chips.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_chips.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chips.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_chips.Location = new System.Drawing.Point(138, 118);
            this.lbl_chips.Name = "lbl_chips";
            this.lbl_chips.Size = new System.Drawing.Size(276, 33);
            this.lbl_chips.TabIndex = 4;
            this.lbl_chips.Text = "Draw some poker chips!";
            // 
            // lbl_demo
            // 
            this.lbl_demo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_demo.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_demo.Location = new System.Drawing.Point(138, 180);
            this.lbl_demo.Name = "lbl_demo";
            this.lbl_demo.Size = new System.Drawing.Size(265, 49);
            this.lbl_demo.TabIndex = 5;
            this.lbl_demo.Text = "Create a user and see the game functionalities";
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(502, 273);
            this.Controls.Add(this.lbl_demo);
            this.Controls.Add(this.lbl_chips);
            this.Controls.Add(this.lbl_deck);
            this.Controls.Add(this.btn_demo);
            this.Controls.Add(this.btn_chips);
            this.Controls.Add(this.btn_deck);
            this.Name = "FormTesting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Testing";
            this.Load += new System.EventHandler(this.FromTesting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deck;
        private System.Windows.Forms.Button btn_chips;
        private System.Windows.Forms.Button btn_demo;
        private System.Windows.Forms.Label lbl_deck;
        private System.Windows.Forms.Label lbl_chips;
        private System.Windows.Forms.Label lbl_demo;
    }
}