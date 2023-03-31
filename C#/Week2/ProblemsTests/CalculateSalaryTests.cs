using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problems.Tests
    {
    [TestClass()]
    public class CalculateSalaryTests
        {
        [TestMethod()]
        public void OverTimeTest()
            {
            double[] inputData = { 13.25, 15, 30, 1.5 };
            string res = CalculateSalary.OverTime(inputData);
            Assert.AreEqual("$ 51.5", res);

            }
        }
    }