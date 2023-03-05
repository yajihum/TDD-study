namespace TDDStudy
{
    public class Money : IExpression
    {
        public int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public bool CheckIsEqual(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && currency == money.currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Sum Plus(Money added)
        {
            return new Sum(this, added);
        }

        public Money Reduce(Bank bank,string to)
        {
            int rate = bank.GetRate(currency, to);
            return new Money(amount / rate, to);
        }

        public string Currency()
        {
            return currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}
