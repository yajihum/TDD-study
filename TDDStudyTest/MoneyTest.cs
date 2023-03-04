using TDDStudy;

namespace TDDStudyTest
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new(5);
            Assert.Equal(new Dollar(10), five.Times(2));
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).CheckIsEquals(new Dollar(5)));
            Assert.False(new Dollar(5).CheckIsEquals(new Dollar(6)));
            Assert.True(new Franc(5).CheckIsEquals(new Franc(5)));
            Assert.False(new Franc(5).CheckIsEquals(new Franc(6)));
            Assert.False(new Franc(5).CheckIsEquals(new Dollar(5)));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            Franc five = new(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }
    }
}