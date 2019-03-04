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
     * Purpose: Model layer of MVC pattern. Defined a base class for all types of customers.
     * 
     */

    public class Customer
    {
        // private properties
        private int accountNo;
        private char customerType;
        private double chargeAmount;

        // public properties
        public int AccountNo {
            get => accountNo;
            set => accountNo = Math.Abs(value);  // if negative, convert to positive
        }
        public string CustomerName { get; set; }
        public char CustomerType { get => customerType; set
            {
                if (value == 'R' || value == 'C' || value == 'I' ||
                    value == 'r' || value == 'c' || value == 'i')
                    customerType = char.ToUpper(value);
                else
                    customerType = 'R';
            }
        }
        public double ChargeAmount
        {
            get => chargeAmount;
            set => chargeAmount = Math.Abs(value);  // if negative, convert to positive
        }

        // constructors
        public Customer(int acctNo = 0, string cName = "", char cType='R', double chargeAmt=0)
        {
            AccountNo = acctNo;
            CustomerName = cName;
            CustomerType = cType;
            ChargeAmount = chargeAmt;
        }

        // methods
        public string ToCSV()
        {
            string str = "";
            str += accountNo.ToString() + ",";
            str += CustomerName + ",";
            str += customerType.ToString() + ",";
            str += chargeAmount.ToString("f2");

            return str;
        }

        public override string ToString()
        {
            string str = "";
            str += accountNo.ToString() + "--";
            str += CustomerName + " (";
            str += customerType.ToString() + "): ";
            str += chargeAmount.ToString("c");

            return str;
        }

        // deprecated method: a dummy calculation method only meant to be overridden in extending classes. But since it does nothing and causing its overridden methods unable to be marked as static, I decided it does more evil than good, hence deprecated it.

        /*
        public virtual double CalculateCharge(int usage, int opUse = 0)
        {
            return 0;
        }
        */

    }
}
