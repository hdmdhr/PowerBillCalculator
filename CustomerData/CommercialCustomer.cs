using CustomerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// Commercial Customer class
    /// </summary>
    public class CommercialCustomer : Customer
    {
        // private properties
        private const double RATE_COMMERCIAL = 0.045;  // rate for commercial
        private const double BASE_COMMERCIAL = 60.00;  // basic charge for commercial
        private const double BASE_USAGE_KWH = 1000;  // usage amount that basic charge covers
        private int usage = 0;  // power usage (kWH)

        // public property
        public int Usage { get => usage; set => usage = Math.Abs(value); }

        // constructor
        public CommercialCustomer(int acctNo = 0, string cName = "", char cType = 'C', double chargeAmt = 0) : base(acctNo, cName, cType, chargeAmt)
        {
        }

        // methods
        public override double CalculateCharge(int usage, int opUse = 0)
        {
            if (usage < 0)
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