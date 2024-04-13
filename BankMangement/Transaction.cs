using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMangement
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Transaction(decimal Amount,DateTime Date, string Description)
        {
            this.Amount = Amount;
            this.Date = Date;   
            this.Description = Description;
           

        }
        public override string ToString()
        {
            return ("Amount :" + Amount + "Date :" + Date + "Description :" + Description);

        }
    }
}
