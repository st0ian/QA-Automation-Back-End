namespace Collections.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExchangeTwoIndex()
        {
            Collection<int> collection_2 = new Collection<int>(new int[] { 1, 2});
            collection_2.Exchange(1, 2);

            Assert.That()
        }
    }
}