namespace TDDStudyXUnit
{
    public class TestResult
    {
        private int runCount = 0;
        private int errorCount = 0;

        public int TestStarted()
        {
            return runCount += 1;
        }

        public int TestFailed()
        {
            return errorCount += 1;
        }

        public string Summary()
        {
            return $"{runCount} run, {errorCount} failed";
        }
    }
}
