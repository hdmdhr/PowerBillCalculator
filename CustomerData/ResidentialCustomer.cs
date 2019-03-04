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
     * Purpose: Model layer of MVC pattern. A class for residential customers.
     * 
     */
    public class ResidentialCustomer : Customer
    {
        // private properties
        private const double RATE_RESIDENTIAL = 0.052;  // rate for residentital
        private const double BASE_RESIDENTIAL = 6.00;  // basic charge for  residential user

        // constructor
        public ResidentialCustomer(int acctNo=0, string cName="", char cType = 'R', double chargeAmt = 0) : base(acctNo, cName, cType, chargeAmt) { }

        // method
        public static double CalculateCharge(int usage)
        {
            if (usage < 0)
                usage = 0;
            return BASE_RESIDENTIAL + usage * RATE_RESIDENTIAL;
        }
    }
}
