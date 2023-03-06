namespace TDDStudy
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce<T>(T source, string to) where T : IExpression
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int GetRate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            return rates.First(x => x.Key.from == from && x.Key.to == to).Value;
        }
    }
}
