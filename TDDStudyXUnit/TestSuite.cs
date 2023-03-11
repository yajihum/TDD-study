namespace TDDStudyXUnit
{
    public class TestSuite
    {
        private readonly List<WasRun> tests = new List<WasRun>();

        public void Add(WasRun test)
        {
            tests.Add(test);
        }

        public void Run(TestResult result)
        {
            foreach(var test in tests)
            {
                test.Run(result);
            }
        }
    }
}
