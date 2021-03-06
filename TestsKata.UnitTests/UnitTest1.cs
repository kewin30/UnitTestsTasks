using NUnit.Framework;
using UnitTestsTasks;

namespace TestsKata.UnitTests
{
    public class Tests
    {
        [TestFixture]
        public class Test
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual("Z", Kata.Battle("AAA", "Z"));
                Assert.AreEqual("TWO", Kata.Battle("ONE", "TWO"));
                Assert.AreEqual("Tie!", Kata.Battle("ONE", "NEO"));
                Assert.AreEqual("FOUR", Kata.Battle("FOUR", "FIVE"));
            }
        }
    }
}