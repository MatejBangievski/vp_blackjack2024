namespace Blackjack
{
    partial class Payment
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_cardnumber = new System.Windows.Forms.Label();
            this.lbl_expirationdate = new System.Windows.Forms.Label();
            this.lbl_ccv = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.mtb_cardnumber = new System.Windows.Forms.MaskedTextBox();
            this.mtb_expirationdate = new System.Windows.Forms.MaskedTextBox();
            this.mtb_ccv = new System.Windows.Forms.MaskedTextBox();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_dollar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_header.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(362, 50);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Please enter your payment card information:";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cardnumber
            // 
            this.lbl_cardnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cardnumber.AutoSize = true;
            this.lbl_cardnumber.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardnumber.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_cardnumber.Location = new System.Drawing.Point(34, 71);
            this.lbl_cardnumber.Name = "lbl_cardnumber";
            this.lbl_cardnumber.Size = new System.Drawing.Size(129, 19);
            this.lbl_cardnumber.TabIndex = 1;
            this.lbl_cardnumber.Text = "Card Number:";
            // 
            // lbl_expirationdate
            // 
            this.lbl_expirationdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_expirationdate.AutoSize = true;
            this.lbl_expirationdate.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expirationdate.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_expirationdate.Location = new System.Drawing.Point(34, 148);
            this.lbl_expirationdate.Name = "lbl_expirationdate";
            this.lbl_expirationdate.Size = new System.Drawing.Size(119, 19);
            this.lbl_expirationdate.TabIndex = 2;
            this.lbl_expirationdate.Text = "Expiration:";
            // 
            // lbl_ccv
            // 
            this.lbl_ccv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ccv.AutoSize = true;
            this.lbl_ccv.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ccv.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_ccv.Location = new System.Drawing.Point(213, 148);
            this.lbl_ccv.Name = "lbl_ccv";
            this.lbl_ccv.Size = new System.Drawing.Size(49, 19);
            this.lbl_ccv.TabIndex = 3;
            this.lbl_ccv.Text = "CCV:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_amount.Location = new System.Drawing.Point(34, 224);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(79, 19);
            this.lbl_amount.TabIndex = 4;
            this.lbl_amount.Text = "Amount:";
            // 
            // mtb_cardnumber
            // 
            this.mtb_cardnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtb_cardnumber.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cardnumber.Location = new System.Drawing.Point(38, 94);
            this.mtb_cardnumber.Mask = "0000 0000 0000 0000";
            this.mtb_cardnumber.Name = "mtb_cardnumber";
            this.mtb_cardnumber.PromptChar = '0';
            this.mtb_cardnumber.Size = new System.Drawing.Size(291, 27);
            this.mtb_cardnumber.TabIndex = 5;
            this.mtb_cardnumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mtb_expirationdate
            // 
            this.mtb_expirationdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtb_expirationdate.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_expirationdate.Location = new System.Drawing.Point(38, 170);
            this.mtb_expirationdate.Mask = "00/0000";
            this.mtb_expirationdate.Name = "mtb_expirationdate";
            this.mtb_expirationdate.PromptChar = '0';
            this.mtb_expirationdate.Size = new System.Drawing.Size(107, 27);
            this.mtb_expirationdate.TabIndex = 6;
            this.mtb_expirationdate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mtb_ccv
            // 
            this.mtb_ccv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtb_ccv.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_ccv.Location = new System.Drawing.Point(213, 170);
            this.mtb_ccv.Mask = "000";
            this.mtb_ccv.Name = "mtb_ccv";
            this.mtb_ccv.PromptChar = '0';
            this.mtb_ccv.Size = new System.Drawing.Size(49, 27);
            this.mtb_ccv.TabIndex = 7;
            this.mtb_ccv.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // nud_amount
            // 
            this.nud_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_amount.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_amount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_amount.Location = new System.Drawing.Point(38, 246);
            this.nud_amount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.nud_amount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(120, 27);
            this.nud_amount.TabIndex = 8;
            this.nud_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_dollar
            // 
            this.lbl_dollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dollar.AutoSize = true;
            this.lbl_dollar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dollar.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbl_dollar.Location = new System.Drawing.Point(161, 248);
            this.lbl_dollar.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_dollar.Name = "lbl_dollar";
            this.lbl_dollar.Size = new System.Drawing.Size(19, 19);
            this.lbl_dollar.TabIndex = 9;
            this.lbl_dollar.Text = "$";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(241, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "min - 5$";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(214, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "max - 2,000,000$";
            // 
            // btn_deposit
            // 
            this.btn_deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deposit.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.ForeColor = System.Drawing.Color.Indigo;
            this.btn_deposit.Location = new System.Drawing.Point(38, 315);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(291, 32);
            this.btn_deposit.TabIndex = 12;
            this.btn_deposit.Text = "DEPOSIT";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(371, 359);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dollar);
            this.Controls.Add(this.nud_amount);
            this.Controls.Add(this.mtb_ccv);
            this.Controls.Add(this.mtb_expirationdate);
            this.Controls.Add(this.mtb_cardnumber);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_ccv);
            this.Controls.Add(this.lbl_expirationdate);
            this.Controls.Add(this.lbl_cardnumber);
            this.Controls.Add(this.lbl_header);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_cardnumber;
        private System.Windows.Forms.Label lbl_expirationdate;
        private System.Windows.Forms.Label lbl_ccv;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.MaskedTextBox mtb_cardnumber;
        private System.Windows.Forms.MaskedTextBox mtb_expirationdate;
        private System.Windows.Forms.MaskedTextBox mtb_ccv;
        private System.Windows.Forms.NumericUpDown nud_amount;
        private System.Windows.Forms.Label lbl_dollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}