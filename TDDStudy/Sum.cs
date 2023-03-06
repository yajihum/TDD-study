namespace TDDStudy
{
    public class Sum : IExpression
    {
        public Money augend;
        public Money added;

        public Sum(Money augend, Money added)
        {
            this.augend = augend;
            this.added = added;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).amount + added.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}
