using NUnit.Framework;

namespace SumApp.UnitTests
{
    internal class Average
    {
        [Test]
        [TestCase(new int[] { 4, 6 }, 5)]
        [TestCase(new int[] { -4, -6 }, -5)]
        [TestCase(new int[] { -4, -6, 4, 6, 10 }, 5)]
        public void MultipleNumbers_ReturnsResult(int[] input, double expectedResult)
        {
            var result = SumApp.Average(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Zero_ReturnsZero()
        {
            var input = new int[] { 0 };
            var expectedResult = 0;

            var result = SumApp.Average(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Null_ThrowsNullException()
        {
            Assert.That(() => SumApp.Average(null), Throws.TypeOf<NullReferenceException>());
        }
    }
}
