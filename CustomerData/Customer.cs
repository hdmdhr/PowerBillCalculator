using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClasses
{
    public abstract class Customer
    {
        // private properties
        private int accountNo;
        private char customerType;
        private double chargeAmount;

        // public properties
        public int AccountNo {
            get => accountNo;
            set => accountNo = Math.Abs(value);
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
            set => chargeAmount = Math.Abs(value);
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
        public override string ToString()
        {
            string str = "";
            str += accountNo.ToString() + ", ";
            str += CustomerName + ", ";
            str += customerType.ToString() + ", ";
            str += chargeAmount.ToString();

            return str;
        }
        // abstract method for further overriding, second parameter opUse is only used for calculating industrial user
        public abstract double CalculateCharge(int usage, int opUse = 0);

    }
}
