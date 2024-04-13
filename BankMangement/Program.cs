using System.Linq.Expressions;

namespace BankMangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Menu = "1. Olayın cüzdan-da hesab açmaq (Bank hesabına bənzər olduğu düşünülməkdədir) \n" +
                "2. Pul yatırmaq \n" +
                "3. Pul çəkmək \n" +
                "4. Balans göstər \n" +
                "5. Hesab hərəkətini göstər\n" +
                "6. Çıxış ";
            bool IsContinue = true;
            BankAccount bankAccount = null;
            while (IsContinue)
            {
                Console.WriteLine(Menu);
                Console.WriteLine("Operationun nomresini daxil edin");
                int Operation = int.Parse(Console.ReadLine());
                switch (Operation)
                {
                    case 1:
                        Console.WriteLine("Adinizi daxil edin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ilkin balansinizi daxil edin");
                        decimal balance = decimal.Parse(Console.ReadLine());
                        bankAccount = new BankAccount(name,balance);
                        break;

                        case 2:
                        if (bankAccount== null)
                        {
                            Console.WriteLine("ilk once bank hesabi acin");
                            break;
                        }
                        Console.WriteLine("Yatiracaginiz pulu daxil edin");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        bankAccount.MakeDeposit(amount,DateTime.Now,"pul yatirildi");
                        break;

                        case 3:
                        if (bankAccount == null)
                        {
                            Console.WriteLine("ilk once bank hesabi acin");
                            break;
                        }
                        Console.WriteLine("cekeceyiniz pulu daxil edin");
                        decimal withdraw  = decimal.Parse(Console.ReadLine());
                       bankAccount.MakeWithdrawal(withdraw, DateTime.Now, "pul cekildi");
                        break;

                        case 4:
                        if (bankAccount == null)
                        {
                            Console.WriteLine("ilk once bank hesabi acin");
                            break;
                        }
                        bankAccount.ShowBalance();
                        break;

                        case 5:
                        if (bankAccount == null)
                        {
                            Console.WriteLine("ilk once bank hesabi acin");
                            break;
                        }
                        bankAccount.ShowAccountActivity();
                        break;

                            case 6:
                        IsContinue = false;
                        break;

                        default:
                        Console.WriteLine("Duzgun operation daxil edin");
                        break;


                   
                }
            }

               



        }
    }
}
