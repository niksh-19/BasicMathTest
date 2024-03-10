namespace BasicMathTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_AddMethod()
        {
            BasicMath basicMath = new BasicMath();
            double result = basicMath.Add(3.5, 2.5);
            Assert.AreEqual(6.0, result);
        }

        [Test]
        public void Test_SubtractMethod()
        {
            BasicMath basicMath = new BasicMath();
            double result = basicMath.Subtract(5.5, 2.5);
            Assert.AreEqual(3.0, result);
        }

        [Test]
        public void Test_DivideMethod()
        {
            BasicMath basicMath = new BasicMath();
            double result = basicMath.Divide(10.0, 2.0);
            Assert.AreEqual(5.0, result);
        }

        [Test]
        public void Test_MultiplyMethod()
        {
            BasicMath basicMath = new BasicMath();
            double result = basicMath.Multiply(2.5, 3.0);
            Assert.AreEqual(7.5, result);
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}