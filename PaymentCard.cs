using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class PaymentCard
    {
        public string CardNumber { get; set; }
        public string CCV { get; set; }
        public string ExpirationDate { get; set; }
        public int Amount { get; set; }

        public PaymentCard(string cardnumber, string ccv, string expirationdate, int amount) { 
            CardNumber = cardnumber;
            CCV = ccv;
            ExpirationDate = expirationdate;
            Amount = amount;
        }
    }
}
