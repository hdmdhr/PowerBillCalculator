using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBillCalculator
{
    public partial class frmUpdate : Form
    {
        // Form-Level Properties
        private string customerName;
        private int accountNum;
        private double chargeAmount;

        public char CustomerType { get; set; }
        public string CustomerName { get=> customerName; set {
                customerName = value;
                txtCustName.Text = value;
            }
        }
        public int AccountNum
        {
            get => accountNum; set
            {
                accountNum = value;
                txtAcctNum.Text = value.ToString();
            }
        }
        public double ChargeAmount
        {
            get => chargeAmount; set
            {
                chargeAmount = value;
                txtCurrentCharge.Text = value.ToString("c");
            }
        }



        public frmUpdate()
        {
            InitializeComponent();
        }

        // constructor
        public frmUpdate(Customer c)
        {
            InitializeComponent();
            CustomerName = c.CustomerName;
            AccountNum = c.AccountNo;
            ChargeAmount = c.ChargeAmount;
            if (c.CustomerType == 'R')
                cmbCustType.SelectedIndex = 0;
            else if (c.CustomerType == 'C')
                cmbCustType.SelectedIndex = 1;
            else
                cmbCustType.SelectedIndex = 2;
        }

        // Add Btn Clicked: add new amount to current amount
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.TBHasNonNegativeDouble(txtAmt, "New Amount"))
                ChargeAmount += Convert.ToDouble(txtAmt.Text);
            // setter of ChargeAmount will do the output
        }

        // Deduct Btn Clicked: deduct new amount from current amount
        private void btnDeduct_Click(object sender, EventArgs e)
        {
            if (Validator.TBHasNonNegativeDouble(txtAmt, "New Amount"))
            {
                if (ChargeAmount < Convert.ToDouble(txtAmt.Text))
                    ChargeAmount = 0;
                else
                    ChargeAmount -= Convert.ToDouble(txtAmt.Text);
            }
        }

        // Update Btn Clicked: save the changed customer info into tag, set dialog result OK
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Tag = new Customer(AccountNum,CustomerName,CustomerType,ChargeAmount);
            this.DialogResult = DialogResult.OK;
        }

        // Cancel Btn Clicked: dismiss dialog, go back
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
