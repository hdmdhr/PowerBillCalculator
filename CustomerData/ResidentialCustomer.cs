using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// Residential Customer class
    /// </summary>
    public class ResidentialCustomer : Customer
    {
        // private properties
        private const double RATE_RESIDENTIAL = 0.052;  // rate for residentital
        private const double BASE_RESIDENTIAL = 6.00;  // basic charge for  residential user

        // constructor
        public ResidentialCustomer(int acctNo=0, string cName="", char cType = 'R', double chargeAmt = 0) : base(acctNo, cName, cType, chargeAmt) { }

        // methods
        public override double CalculateCharge(int usage, int opUse = 0)
        {
            if (usage < 0)
                usage = 0;
            return BASE_RESIDENTIAL + usage * RATE_RESIDENTIAL;
        }
    }
}
