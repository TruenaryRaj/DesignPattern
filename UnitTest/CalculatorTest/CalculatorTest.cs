namespace CalculatorTest
{
    using Calculator;
    [TestClass]
    public sealed class CalculatorTest
    {
       [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(5, Program.Add(3, 2));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(3, Program.Subtract(3, 0));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(0, Program.Multiply(3, 0));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(0, Program.Division(0, 3));
        }
    }

}