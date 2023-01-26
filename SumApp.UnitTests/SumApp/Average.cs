using NUnit.Framework;

namespace SumApp.UnitTests
{
    internal class Average
    {
        [Test]
        public void TwoNumbers_ReturnsResult()
        {
            var input = new int[] { 4, 6 };
            var expectedResult = 5;

            var result = SumApp.Average(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TwoNegative_ReturnsResult()
        {
            var input = new int[] { -4, -6 };
            var expectedResult = -5;

            var result = SumApp.Average(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void MultipleNumbers_ReturnsResult()
        {
            var input = new int[] { -4, -6, 4, 6, 10 };
            var expectedResult = 5;

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
