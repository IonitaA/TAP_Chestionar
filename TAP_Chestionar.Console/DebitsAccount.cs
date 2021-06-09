namespace TAP_Chestionar.Console
{
    public class DebitsAccount : Account
    {
        protected override decimal Calculeazawithdrawfee(decimal amount)
        {
            return 0m;
        }
    }
}
