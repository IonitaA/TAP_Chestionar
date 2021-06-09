namespace TAP_Chestionar.Console
{
    public class SavingsAccount : Account
    {
        protected override decimal Calculeazawithdrawfee(decimal amount)
        {
            return amount * 0.5m /100m;
        }
    }
}
