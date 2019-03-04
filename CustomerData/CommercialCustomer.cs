using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /*
     * Author: DongMing Hu
     * Date: Feb. 27, 2019
     * Purpose: Model layer of MVC pattern. A class for commercial customers.
     * 
     */
    public class CommercialCustomer : Customer
    {
        // private properties
        private const double RATE_COMMERCIAL = 0.045;  // rate for commercial
        private const double BASE_COMMERCIAL = 60.00;  // basic charge for commercial
        private const double BASE_USAGE_KWH = 1000;  // usage amount that basic charge covers

        // constructor
        public CommercialCustomer(int acctNo = 0, string cName = "", char cType = 'C', double chargeAmt = 0) : base(acctNo, cName, cType, chargeAmt)
        {
        }

        // method
        public static double CalculateCharge(int usage)
        {
            if (usage < 0)  // if usage is negative, change to 0
                usage = 0;
            double totalAmt = 0;
            if (usage <= BASE_USAGE_KWH)
                totalAmt = BASE_COMMERCIAL;
            else
                totalAmt = BASE_COMMERCIAL + (usage - BASE_USAGE_KWH) * RATE_COMMERCIAL;

            return totalAmt;
        }
    }
}