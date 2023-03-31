using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Testing.Tests
{
    [TestClass()]
    public class CGPACalculatorClassTests : CGPACalculatorClass
    {
        [TestMethod()]
        public void TestMain()
        {
            Main();
            if (grade == "B")
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateCGPATest_B()
        {
            int subjectCount = 3;
            List<float> marks = new List<float>() { 90.0f, 80.0f, 60.0f };
            string grade = CalculateCGPA(subjectCount, marks);
            if (grade == "B")
            {

                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void CalculateCGPATest_C()
        {
            int subjectCount = 3;
            List<float> marks = new List<float>() { 90.0f, 80.0f, 60.0f };
            string grade = CalculateCGPA(subjectCount, marks);
            if (grade == "B")
            {

                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}