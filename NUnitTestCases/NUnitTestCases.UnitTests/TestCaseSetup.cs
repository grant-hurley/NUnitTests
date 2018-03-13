using System.Collections;

namespace NUnitTestCases.UnitTests
{
    public class AdderTestCaseSetup
    {
        public string Description { get; set; }
        public double LHS { get; set; }
        public double RHS { get; set; }
        public double Expected { get; set; }
    }

    public class TestCaseSetup : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            var ones = new AdderTestCaseSetup { LHS = 1, RHS = 1, Expected = 2, Description = "Sql Server with Rabbit" }; // Description is used solely for visibility in the test window
            var twos = new AdderTestCaseSetup { LHS = 2, RHS = 2, Expected = 5, Description = "MySql with Rabbit"};
            var threes = new AdderTestCaseSetup { LHS = 3, RHS = 3, Expected = 6, Description = "MySql with InMemory" };

            yield return new object[] { ones, ones.Description };
            yield return new object[] { twos, twos.Description };
            yield return new object[] { threes, threes.Description };
        }
    }
}
