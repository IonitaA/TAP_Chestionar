using System;

namespace TAP_Chestionar.Console
{

    public class AtmSingelton
    {
        private readonly DebitsAccount _debitAccount;
        public static readonly AtmSingelton _instance = new AtmSingelton();

        private AtmSingelton()
        {
            _debitAccount = new DebitsAccount();
        }
        public static AtmSingelton Instance => _instance;

        public DebitsAccount DebitAccount => _debitAccount;
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            AtmSingelton.Instance.DebitAccount.Deposit(100);
            AtmSingelton.Instance.DebitAccount.WithDraw(10);
            var account = new SavingsAccount();
            account.Deposit(200);

            System.Console.WriteLine($"Disponibil: {account.Balance} Ron");

            try
            {
                account.WithDraw(100);
            }
            catch (InvalidOperationException)
            {
                System.Console.WriteLine("Fonduri insuficiente");
            }
           
            System.Console.WriteLine($"Disponibil: {account.Balance} Ron");
        }
    }
}
