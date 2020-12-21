using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;

namespace lab3.tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void CheckInitial()
        {
            Rectangle temp = new Rectangle();
            Assert.AreEqual(0, temp.a);
            Assert.AreEqual(0, temp.b);

            Rectangle temp1 = new Rectangle(5, 1);
            Assert.AreEqual(5, temp1.a);
            Assert.AreEqual(1, temp1.b);
        }
        [TestMethod]
        public void TestSetAB()
        {
            Rectangle temp = new Rectangle();
            temp.setAB(5, 10);
            Assert.AreEqual(5, temp.a);
            Assert.AreEqual(10, temp.b);
        }
        [TestMethod]
        public void TestSetASetB()
        {
            Rectangle temp = new Rectangle();
            temp.setA(7);
            temp.setB(8);
            Assert.AreEqual(7, temp.a);
            Assert.AreEqual(8, temp.b);
        }
        [TestMethod]
        public void TestGetSquare()
        {
            Rectangle temp = new Rectangle(5, 10);
            Assert.AreEqual(50, temp.getSquare());
        }
        [TestMethod]
        public void TestGetPerimetr()
        {
            Rectangle temp = new Rectangle(5, 10);
            Assert.AreEqual(30, temp.getPerimeter());
        }
        [TestMethod]
        public void TestIsSquare()
        {
            Rectangle temp = new Rectangle(5, 10);
            Assert.AreEqual(false, temp.isSquare());
            Rectangle temp2 = new Rectangle(5, 5);
            Assert.AreEqual(true, temp2.isSquare());
        }
        [TestMethod]
        public void TestIsCorrect()
        {
            Rectangle temp = new Rectangle(1, 11);
            Assert.AreEqual(true, temp.isCorrect());
            Rectangle temp2 = new Rectangle();
            Assert.AreEqual(false, temp2.isCorrect());
            Rectangle temp3 = new Rectangle(-1, 10);
            Assert.AreEqual(false, temp3.isCorrect());
        }
    }
}
