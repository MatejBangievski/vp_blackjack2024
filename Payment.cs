using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Payment : Form
    {
        public PaymentCard playercard;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (playercard != null)
            {
                mtb_cardnumber.Text = playercard.CardNumber;
                mtb_expirationdate.Text = playercard.ExpirationDate;
                mtb_ccv.Text = playercard.CCV;
                nud_amount.Value = playercard.Amount;
            }
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            ValidateDate();
        }

        private void ValidateDate () //За да се валидира иако не е кликнато полето (не се повикува со validating)
        {
            string input = mtb_expirationdate.Text;

            if (IsValidDate(input))
            {
                errorProvider1.SetError(mtb_expirationdate, string.Empty);

                //if (mtb_cardnumber.MaskCompleted && mtb_expirationdate.MaskCompleted) //вака не може да бидат 0
                string cardnumber = mtb_cardnumber.Text;
                string expirationdate = mtb_expirationdate.Text;
                string ccv = mtb_ccv.Text;
                int amount = (int)nud_amount.Value; //Враќа decimal

                playercard = new PaymentCard(cardnumber, ccv, expirationdate, amount);

                DialogResult = DialogResult.OK;
            }
            else
            {
                errorProvider1.SetError(mtb_expirationdate, "Invalid or expired date.");
            }
        }

        private bool IsValidDate (string input)
        {
            DateTime date;
            //Со помош од GPT
            if (DateTime.TryParseExact(input, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                DateTime now = DateTime.Now;
                if (date.Year > now.Year)
                {
                    return true;
                } 
                else if (date.Year == now.Year)
                {
                    if (date.Month >= now.Month)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
