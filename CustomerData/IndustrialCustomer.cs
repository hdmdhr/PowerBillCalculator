using CustomerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// Industrial Customer Class
    /// </summary>
    public class IndustrialCustomer : Customer
    {
        // private properties
        private const double PH_INDUSTRIAL = 0.065;  // peak hour rate for industrial user
        private const double OP_INDUSTRIAL = 0.028; // off peak rate for industrial user
        private const double PH_BASE_INDUSTRIAL = 76.00;  // basic charge for industrial peak hour use
        private const double OP_BASE_INDUSTRIAL = 40.00;  // basic charge for industrial off peak use
        private const double BASE_USAGE_KWH = 1000;  // usage amount that basic charge covers

        public double peakAmt, opAmt;  // for outputing amount separately

        // constructor
        public IndustrialCustomer(int acctNo = 0, string cName = "", char cType = 'I', double chargeAmt = 0) : base(acctNo, cName, cType, chargeAmt)
        {
        }

        // methods
        public override double CalculateCharge(int peakUse, int opUse = 0)
        {
            if (peakUse < 0) peakUse = 0;
            if (opUse < 0) opUse = 0;

            if (peakUse <= BASE_USAGE_KWH)
                peakAmt = PH_BASE_INDUSTRIAL;
            else
                peakAmt = PH_BASE_INDUSTRIAL + (peakUse - BASE_USAGE_KWH) * PH_INDUSTRIAL;

            if (opUse <= BASE_USAGE_KWH)
                opAmt = OP_BASE_INDUSTRIAL;
            else
                opAmt = OP_BASE_INDUSTRIAL + (opUse - BASE_USAGE_KWH) * OP_INDUSTRIAL;

            return peakAmt + opAmt;
        }
    }
}
