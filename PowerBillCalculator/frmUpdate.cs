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
        // properties
        private string customerName;
        public string CustomerName { get=> customerName; set {
                customerName = value;
                txtCustName.Text = value;
            }
        }
        private int accountNum;
        public int AccountNum
        {
            get => accountNum; set
            {
                accountNum = value;
                txtAcctNum.Text = value.ToString();
            }
        }
        private double chargeAmount;
        public double ChargeAmount
        {
            get => chargeAmount; set
            {
                chargeAmount = value;
                txtCurrentCharge.Text = value.ToString("c");
            }
        }
        public char CustomerType { get; set; }



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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDeduct_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
