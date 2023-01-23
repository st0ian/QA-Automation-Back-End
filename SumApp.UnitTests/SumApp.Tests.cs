using NUnit.Framework;
using SumApp;

namespace SumApp.UnitTests
{
    public class Tests
    {
        [Test]
        public void SumTwoNumbers()
        {
            var input = new int[] { 4, 6 };
            var expectedResult = 10;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SumTwoNegative()
        {
            var input = new int[] { -4, -6 };
            var expectedResult = -10;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SumEmptyArray()
        {
            var input = new int[] { };
            var expectedResult = 0;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SumOneNumber()
        {
            var input = new int[] { 1 };
            var expectedResult = 1;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SumBugNumbers()
        {
            var input = new int[] {4000000, 4000000};
            var expectedResult = 8000000;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}