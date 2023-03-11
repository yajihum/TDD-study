namespace TDDStudyXUnit
{
    public class WasRun : TestCase
    {
        public string name;
        public string log;

        public WasRun(string name) : base(name)
        {
            this.name = name;
            log = name;
        }

        public override void TestMethod()
        {
            log += " testMethod";
        }

        public override void TestBrokenMethod()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            log += " tearDown";
        }
    }
}
