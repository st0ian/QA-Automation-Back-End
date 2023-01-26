using NUnit.Framework;

namespace SumApp.UnitTests
{
    public class Sum
    {
        [Test]
        public void MultipleNumbers_ReturnsResult()
        {
            var input = new int[] { -4, -6, 4, 6, 10 };
            var expectedResult = 10;

            var result = SumApp.Sum(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TwoNumbers_ReturnsResult()
        {
            var input = new int[] { 4, 6 };
            var expectedResult = 10;

            var result = SumApp.Sum(input);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TwoNegative_ReturnsResult()
        {
            var input = new int[] { -4, -6 };
            var expectedResult = -10;

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
        public void OneNumber_ReturnsResult()
        {
            var input = new int[] { 1 };
            var expectedResult = 1;

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