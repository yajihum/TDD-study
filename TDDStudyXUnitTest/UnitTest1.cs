using TDDStudyXUnit;
using Xunit.Abstractions;

namespace TDDStudyXUnitTest
{
    public class UnitTest1 : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly WasRun test;
        private readonly TestResult result;

        // setup
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;

            test = new WasRun("setup");
            result = new TestResult();
        }

        public void Dispose()
        {
            test.Dispose();
            _output.WriteLine(test.log);
        }

        [Fact]
        public void TestSetup()
        {
            test.Run(result);
            Assert.True("setup testMethod" == test.log);
        }

        [Fact]
        public void TestResult()
        {
            test.Run(result);
            Assert.True("1 run, 0 failed" == result.Summary());
        }

        [Fact]
        public void TestFailedResult()
        {
            test.Run(result);
            Assert.True("1 run, 1 failed" == result.Summary());
        }

        [Fact]
        public void TestFailedResultFormatting()
        {
            result.TestStarted();
            result.TestFailed();
            Assert.True("1 run, 1 failed" == result.Summary());
        }

        [Fact]
        public void TestSuite()
        {
            TestSuite suite = new TestSuite();
            suite.Add(new WasRun("testMethod"));
            suite.Add(new WasRun("testBrokenMethod"));
            suite.Run(result);
            Assert.True("2 run, 1 failed" == result.Summary());
        }
    }
}