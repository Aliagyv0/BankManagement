using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankMangement
{
    public class BankAccount
    {

        public string Number { get; }
        public string Owner { get; set; }
        private  decimal Balance { get; set; }
        private List<Transaction> transactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount<0)
            {
                Console.WriteLine("Yatirdiginiz pul 0-dan boyuk olmalidir.");
                return;
            }
            
            Balance += amount;
            Transaction transaction = new Transaction(amount,DateTime.Now, "pul yatirma");
            transactions.Add(transaction);
            Console.WriteLine("Ugurlu emeliyyat");
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (Balance<amount)
            {
                Console.WriteLine("Balanceda kifayet qeder mebleg yoxdur.");
                return;
            }
            Balance -= amount;
            Transaction transaction = new Transaction(amount, DateTime.Now,"pul cekme");
            transactions.Add(transaction);
            Console.WriteLine("Ugurlu emeliyyat");

        }
        public BankAccount(string Name, decimal initionalBalance)
        {
            Owner = Name;
            Balance = initionalBalance;
            Number = Guid.NewGuid().ToString();
            Console.WriteLine("ugurlu bank hesabi yarandi\n" +
                "hesab nomresi :"+ Number +" adi :"+Name + " ilkin balans : " +initionalBalance);

        }
        public void ShowBalance()
        {
            Console.WriteLine("Balansiniz :" + Balance);
        }
        public void ShowAccountActivity()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }


    }
}
