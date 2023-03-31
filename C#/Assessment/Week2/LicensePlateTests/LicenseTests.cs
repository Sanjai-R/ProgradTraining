using Microsoft.VisualStudio.TestTools.UnitTesting;
using LicensePlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LicensePlate.Tests
{
    [TestClass()]
    public class LicenseTests
    {


        [TestMethod()]
        public void ConversionPlateTest()
        {
            Assert.AreEqual(License.ConversionPlate("5F3Z-2e-9-w", 4), "5F3Z-2E9W");
        }


        [TestMethod()]
        public void LicenseTimeTest()
        {
            Assert.AreEqual(LicenseTime.License("Zebediah", 1, "Bob Jim Becky Pat"), 100);
        }

    }

}