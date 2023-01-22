using NUnit.Framework;
using SumApp;

namespace SumApp.UnitTests
{
    public class Tests
    {
        [Test]
        public void SumAppTests()
        {
            var input = new int[] { 4, 6 };

            var result = SumApp.Sum(input);
            var expectedResult = 10;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestA()
        {
            SumApp.Proba();
        }

    }
}