using TDDStudy;

namespace TDDStudyTest
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10).amount, five.Times(2).amount);
            Assert.Equal(Money.Dollar(15).amount, five.Times(3).amount);
        }

        [Fact]
        public void TestSimpleAdditon()
        {
            Money five = Money.Dollar(5);
            Sum sum = five.Plus(five);
            Money reduced = new Bank().Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(10).amount, reduced.amount);
        }

        [Fact]
        public void TestPlusReturnsSum()
        {
            Money five = Money.Dollar(5);
            Sum sum = five.Plus(five);
            Assert.Equal(five, sum.augend);
            Assert.Equal(five, sum.added);
        }

        [Fact]
        public void TestReduceSum()
        {
            Sum sum = new(Money.Dollar(3), Money.Dollar(4));
            Money result = new Bank().Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(7), result);
        }

        [Fact]
        public void TestReduceMoney()
        {
            Money result = new Bank().Reduce(Money.Dollar(1), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.Equal(Money.Dollar(1), result);
        }

        [Fact]
        public void TestMixedAdditon()
        {
            Money fiveBucks = Money.Dollar(5);
            Money tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), "USD");
            Assert.Equal(Money.Dollar(10), result);
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).CheckIsEqual(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).CheckIsEqual(Money.Dollar(6)));
            Assert.False(Money.Franc(5).CheckIsEqual(Money.Dollar(5)));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }

        [Fact]
        public void TestIndentityRate()
        {
            Assert.Equal(1, new Bank().GetRate("USD", "USD"));
        }
    }
}