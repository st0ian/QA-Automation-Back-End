using NUnit.Framework;

namespace SumApp.UnitTests
{
    public class Sum
    {
        [Test]
        [TestCase(new int[] { -4, -6, 4, 6, 10 }, 10)]
        [TestCase(new int[] { 4, 6 }, 10)]
        [TestCase(new int[] { -4, -6 }, -10)]
        [TestCase(new int[] { 0, 5, -5 }, 0)]
        public void SumNumbers_ReturnsResult(int[] input, int expectedResult)
        {
            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void OneNumber_ReturnsResult()
        {
            var input = new int[] { 1 };
            var expectedResult = 0;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void EmptyArray_ReturnsZero()
        {
            var input = new int[] { };
            var expectedResult = 0;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void BugNumbers_ReturnsResult()
        {
            var input = new int[] { 4000000, 4000000 };
            var expectedResult = 8000000;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Null_ThrowsNullException()
        {
            Assert.That(() => SumApp.Sum(null), Throws.TypeOf<NullReferenceException>());
        }
    }
}
