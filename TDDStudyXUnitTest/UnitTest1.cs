using TDDStudyXUnit;
using Xunit.Abstractions;

namespace TDDStudyXUnitTest
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            var test = new WasRun("testMethod"); ;
            _output.WriteLine($"{test.wasRun}");
            Assert.False(test.wasRun);
            test.Run();
            _output.WriteLine($"{test.wasRun}");
        }
    }
}