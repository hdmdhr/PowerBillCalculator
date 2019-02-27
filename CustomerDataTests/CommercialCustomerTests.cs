﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CommercialCustomerTests
    {
        // Test 1: negative usage
        [TestMethod()]
        public void CalculateChargeNegativeUsageTest()
        {
            // Arrange
            int usage = -1000;
            double expectedCharge = 60;
            double actualCharge;
            // Act
            var dummyCommercial = new CommercialCustomer();
            actualCharge = dummyCommercial.CalculateCharge(usage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 2: positive, below base usage amount (1000 kwh)
        [TestMethod()]
        public void CalculateChargeBelowBaseTest()
        {
            // Arrange
            int usage = 500;
            double expectedCharge = 60;
            double actualCharge;
            // Act
            var dummyCommercial = new CommercialCustomer();
            actualCharge = dummyCommercial.CalculateCharge(usage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        // Test 3: positive, above base usage amount
        [TestMethod()]
        public void CalculateChargeAboveBaseTest()
        {
            // Arrange
            int usage = 2000;
            double expectedCharge = 105;
            double actualCharge;
            // Act
            var dummyCommercial = new CommercialCustomer();
            actualCharge = dummyCommercial.CalculateCharge(usage);
            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }


    }  // class
}  // namespace