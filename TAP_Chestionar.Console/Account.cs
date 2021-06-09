using System;

namespace TAP_Chestionar.Console
{
    public abstract class Account{
        public decimal Balance{get;private set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public decimal WithDraw(decimal amount)
        {
            var fee = Calculeazawithdrawfee(amount);
            amount += fee;
            if (Balance < amount) {
                throw new InvalidOperationException("Insuficient founds!");
            }
            this.Balance -= amount;
            return amount;
        }

        protected abstract decimal Calculeazawithdrawfee(decimal amount);
    }
}
