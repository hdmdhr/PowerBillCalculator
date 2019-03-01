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
    public class ResidentialCustomerTests
    {
        // Test 1: negative usage
        [TestMethod()]
        public void CalculateChargeWithNegativeUsage()
        {
            // Arrange
            int usage = -1000;
            double expectedCharge = 6;
            double actualCharge;
            // Act
            actualCharge = ResidentialCustomer.CalculateCharge(usage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 2: positive usage
        [TestMethod()]
        public void CalculateChargeWithPositiveUsage()
        {
            // Arrange
            int usage = 1000;
            double expectedCharge = 58;
            double actualCharge;
            // Act
            actualCharge = ResidentialCustomer.CalculateCharge(usage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 3: zero usage
        [TestMethod()]
        public void CalculateChargeWithZeroUsage()
        {
            // Arrange
            int usage = 0;
            double expectedCharge = 6;
            double actualCharge;
            // Act
            actualCharge = ResidentialCustomer.CalculateCharge(usage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

    }
}