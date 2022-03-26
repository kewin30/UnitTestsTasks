using NUnit.Framework;
using UnitTestsTasks;

namespace Solution.UnitTests
{
    public class Tests
    {

        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(2));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(1));
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(7));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(-1));
        }
    }
}