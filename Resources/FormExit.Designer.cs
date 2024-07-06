namespace Blackjack.Resources
{
    partial class FormExit
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_ty = new System.Windows.Forms.Label();
            this.lbl_wonlost = new System.Windows.Forms.Label();
            this.lbl_totalgames = new System.Windows.Forms.Label();
            this.lbl_totalwins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_ty
            // 
            this.lbl_ty.AutoSize = true;
            this.lbl_ty.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_ty.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ty.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_ty.Location = new System.Drawing.Point(42, 56);
            this.lbl_ty.Name = "lbl_ty";
            this.lbl_ty.Size = new System.Drawing.Size(328, 29);
            this.lbl_ty.TabIndex = 0;
            this.lbl_ty.Text = "THANK YOU FOR PLAYING";
            // 
            // lbl_wonlost
            // 
            this.lbl_wonlost.AutoSize = true;
            this.lbl_wonlost.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_wonlost.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wonlost.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_wonlost.Location = new System.Drawing.Point(114, 85);
            this.lbl_wonlost.Name = "lbl_wonlost";
            this.lbl_wonlost.Size = new System.Drawing.Size(193, 29);
            this.lbl_wonlost.TabIndex = 1;
            this.lbl_wonlost.Text = "You won/lost";
            // 
            // lbl_totalgames
            // 
            this.lbl_totalgames.AutoSize = true;
            this.lbl_totalgames.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_totalgames.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalgames.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_totalgames.Location = new System.Drawing.Point(135, 125);
            this.lbl_totalgames.Name = "lbl_totalgames";
            this.lbl_totalgames.Size = new System.Drawing.Size(154, 23);
            this.lbl_totalgames.TabIndex = 2;
            this.lbl_totalgames.Text = "Total games:";
            // 
            // lbl_totalwins
            // 
            this.lbl_totalwins.AutoSize = true;
            this.lbl_totalwins.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_totalwins.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalwins.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_totalwins.Location = new System.Drawing.Point(135, 148);
            this.lbl_totalwins.Name = "lbl_totalwins";
            this.lbl_totalwins.Size = new System.Drawing.Size(142, 23);
            this.lbl_totalwins.TabIndex = 3;
            this.lbl_totalwins.Text = "Total wins:";
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.EXITSCREEN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(559, 559);
            this.Controls.Add(this.lbl_totalwins);
            this.Controls.Add(this.lbl_totalgames);
            this.Controls.Add(this.lbl_wonlost);
            this.Controls.Add(this.lbl_ty);
            this.Name = "FormExit";
            this.Text = "FormExit";
            this.Load += new System.EventHandler(this.FormExit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_ty;
        private System.Windows.Forms.Label lbl_wonlost;
        private System.Windows.Forms.Label lbl_totalgames;
        private System.Windows.Forms.Label lbl_totalwins;
    }
}