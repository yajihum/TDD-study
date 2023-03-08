namespace TDDStudyXUnit
{
    public class WasRun : TestCase
    {
        public bool wasRun;

        public WasRun(string name) : base(name)
        {
            wasRun = false;
        }

        public void Run()
        {
            TestMethod();
        }

        private void TestMethod()
        {
            wasRun = true;
        }
    }
}
