namespace TDDStudy
{
    public class Money
    {
        protected int amount;

        public bool CheckIsEquals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && this.GetType() == money.GetType();
        }
    }
}
