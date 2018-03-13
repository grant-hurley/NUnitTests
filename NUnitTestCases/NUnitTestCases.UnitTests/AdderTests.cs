using NUnit.Framework;

namespace NUnitTestCases.UnitTests
{
    [TestFixture]
    public class AdderTests
    {
        [Test, TestCaseSource(typeof(TestCaseSetup))]
        public void TestAdd(AdderTestCaseSetup setup, string s)
        {
            //Arrange
            var adder = new Adder();

            //Act
            var result = adder.Add(setup.LHS, setup.RHS);

            //Assert
            Assert.AreEqual(setup.Expected, result);
        }
    }
}
