namespace TDDStudy
{
    public interface IExpression
    {
        public Money Reduce(Bank bank, String to);
    }
}
