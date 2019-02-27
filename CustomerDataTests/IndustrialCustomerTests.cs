using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class IndustrialCustomerTests
    {
        // Test 1: negative usage
        [TestMethod()]
        public void CalculateChargeNegativeUsageTest()
        {
            // Arrange
            int phUsage = -1000, opUsage = -1000;
            double expectedCharge = 116;
            double actualCharge;
            // Act
            var dummyIndustrial = new IndustrialCustomer();
            actualCharge = dummyIndustrial.CalculateCharge(phUsage, opUsage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 2: positive, only peak hour usage above base usage amount (1000 kwh)
        [TestMethod()]
        public void CalculateChargePeakAboveBaseTest()
        {
            // Arrange
            int phUsage = 2000, opUsage = 100;
            double expectedCharge = 181;
            double actualCharge;
            // Act
            var dummyIndustrial = new IndustrialCustomer();
            actualCharge = dummyIndustrial.CalculateCharge(phUsage, opUsage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 3: positive, only off peak usage above base usage amount (1000 kwh)
        [TestMethod()]
        public void CalculateChargeOpAboveBaseTest()
        {
            // Arrange
            int phUsage = 100, opUsage = 2000;
            double expectedCharge = 144;
            double actualCharge;
            // Act
            var dummyIndustrial = new IndustrialCustomer();
            actualCharge = dummyIndustrial.CalculateCharge(phUsage, opUsage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 4: positive, both usage above base usage amount (1000 kwh)
        [TestMethod()]
        public void CalculateChargeBothAboveBaseTest()
        {
            // Arrange
            int phUsage = 2000, opUsage = 2000;
            double expectedCharge = 209;
            double actualCharge;
            // Act
            var dummyIndustrial = new IndustrialCustomer();
            actualCharge = dummyIndustrial.CalculateCharge(phUsage, opUsage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 5: positive, both usage below base usage amount (1000 kwh)
        [TestMethod()]
        public void CalculateChargeBothBelowBaseTest()
        {
            // Arrange
            int phUsage = 100, opUsage = 100;
            double expectedCharge = 116;
            double actualCharge;
            // Act
            var dummyIndustrial = new IndustrialCustomer();
            actualCharge = dummyIndustrial.CalculateCharge(phUsage, opUsage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

    }
}