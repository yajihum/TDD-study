namespace TDDStudyXUnit
{
    public abstract class TestCase
    {
        protected string name;

        public TestCase(string name)
        {
            this.name = name;
        }

        public void Run(TestResult result)
        {
            try
            {
                result.TestStarted();
                if (name == "testMethod")
                {
                    TestMethod();
                }
                else
                {
                    TestBrokenMethod();
                }
            }
            catch
            {
                result.TestFailed();
            }
        }

        public abstract void TestMethod();

        public abstract void TestBrokenMethod();

        public abstract void Dispose();
    }
}
